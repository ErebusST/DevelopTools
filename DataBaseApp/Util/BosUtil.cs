using BaiduBce;
using BaiduBce.Auth;
using BaiduBce.Services.Bos;
using BaiduBce.Services.Bos.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateProject.Util
{
    class BosUtil
    {
        #region 常量
        //private String accessKey = "f7053aa4d5f04a019149088563527c1d";//Access Key ID
        private String accessKey = XMLUtil.getValue("AccessKey");// "";// "0d537038030b4597a8c7a8d0e52f90c8";
        private String sccretAccessKey = XMLUtil.getValue("SecretKey");//"";//"0de57fe4d891467282350714d25f4720";//Secret Access Key
        // private String sccretAccessKey = "497cc57ea0c344399d940cc7a58cf694";//Secret Access Key
        private String endpoint = XMLUtil.getValue("EndPoint");//"";//"http://bj.bcebos.com";//指定BOS服务域名
        private String delimter = "/";//路径分隔字符
        private long comparisonPartSize = 100 * 1024 * 1024 * 5L;//上传文件大小 如果 大于此数字，分块使用按1M算，如果大于此大小 分块按20M算

        public String AccessKey
        {
            set { this.accessKey = value; }
        }

        public String SecretKey
        {
            set { this.sccretAccessKey = value; }
        }

        public String EndPoint
        {
            set { this.endpoint = value; }
        }

        BosClient bosClient = null;
        #endregion

        #region Bucket相关

        /// <summary>
        /// 创建Bucket
        /// </summary>
        /// <param name="bucketName"></param>
        /// <returns></returns>
        public Boolean CreateBucket(String bucketName)
        {
            BosClient client = GenerateBosClient();
            bool exists = client.DoesBucketExist(bucketName);
            if (exists)
            {
                throw new Exception("待创建的[ " + bucketName + " ]已经存在！");
            }
            else
            {
                client.CreateBucket(bucketName);
                return true;
            }
        }

        /// <summary>
        /// 获取现有的bucket列表
        /// </summary>
        /// <returns></returns>
        public List<BucketSummary> getBucketList()
        {

            BosClient client = GenerateBosClient();
            // 获取用户的Bucket列表
            List<BucketSummary> buckets = client.ListBuckets().Buckets;
            return buckets;
        }

        /// <summary>
        /// 判断bucket是否存在
        /// </summary>
        /// <param name="bucketName"></param>
        /// <returns></returns>
        public Boolean checkBucketExist(String bucketName)
        {
            BosClient client = GenerateBosClient();
            bool exists = client.DoesBucketExist(bucketName);
            return exists;
        }

        #endregion

        #region 获取文件方法
        /// <summary>
        /// 取得某个存储bucket下所有的文件信息，不包含文件夹
        /// </summary>
        /// <param name="bucketName"></param>
        /// <returns></returns>
        public List<BosObjectSummary> getObjectsList(String bucketName)
        {

            BosClient client = GenerateBosClient();
            List<BosObjectSummary> objects = client.ListObjects(bucketName).Contents;
            return objects;
        }

        public ListObjectsResponse getAllObjectsList(String bucketName, String path)
        {

            BosClient client = GenerateBosClient();
            ListObjectsResponse objects = client.ListObjects(bucketName, path);
            return objects;
        }

        /// <summary>
        /// 获得bucket下所有文件夹信息
        /// </summary>
        /// <param name="bucketName"></param>
        /// <returns></returns>
        public List<ObjectPrefix> getFoldersList(String bucketName)
        {
            BosClient client = GenerateBosClient();
            List<ObjectPrefix> folderList = client.ListObjects(bucketName).CommonPrefixes;
            return folderList;
        }

        /// <summary>
        /// 获取路径下的文件列表，包含文件和文件夹
        /// </summary>
        /// <param name="bucketName">存储的bucketName</param>
        /// <param name="filter">path。路径</param>
        /// <returns></returns>
        public ListObjectsResponse getObjectsList(String bucketName, String path)
        {
            BosClient client = GenerateBosClient();
            ListObjectsRequest listObjectsRequest = new ListObjectsRequest();
            listObjectsRequest.BucketName = bucketName;
            listObjectsRequest.Delimiter = delimter;
            listObjectsRequest.Prefix = path;
            ListObjectsResponse response = client.ListObjects(listObjectsRequest);
            return response;
        }

        public String ListDir(String bucketName, String dirName)
        {
            try
            {
                BosClient client = GenerateBosClient();
                ListObjectsRequest listObjectsRequest = new ListObjectsRequest();
                listObjectsRequest.BucketName = bucketName;
                listObjectsRequest.Delimiter = delimter;
                listObjectsRequest.Prefix = dirName;
                ListObjectsResponse response = client.ListObjects(listObjectsRequest);

                JArray jsonArray = new JArray();
                ;
                //处理文件
                int fileCount = 0;
                foreach (BosObjectSummary obj in response.Contents)
                {
                    String objName = obj.Key;
                    if (objName.Equals(dirName))
                    {
                        continue;
                        //objName = "../";
                    }
                    else if (dirName.Length != 0)
                    {
                        objName = objName.Replace(dirName, "");
                    }
                    fileCount++;
                    String objSize = Util.formatSize(obj.Size);
                    String objDate = obj.LastModified.ToString("yyyy-MM-dd H:mm");
                    String objKey = obj.Key;
                    JObject jsonObject = new JObject();
                    jsonObject.Add("objName", objName);
                    jsonObject.Add("objSize", objSize);
                    jsonObject.Add("long", obj.Size);
                    jsonObject.Add("objDate", objDate);
                    jsonObject.Add("objKey", objKey);
                    jsonObject.Add("objType", "F");
                    jsonArray.Add(jsonObject);
                }
                //处理文件夹
                int dirCount = 0;
                foreach (ObjectPrefix obj in response.CommonPrefixes)
                {
                    String objName = obj.Prefix;
                    if (objName.Equals(dirName))
                    {
                        continue;
                        //objName = "../";
                    }
                    else if (dirName.Length != 0)
                    {
                        objName = objName.Replace(dirName, "");
                    }
                    dirCount++;
                    String objKey = obj.Prefix;
                    JObject jsonObject = new JObject();
                    jsonObject.Add("objName", objName);
                    jsonObject.Add("objSize", "-");
                    jsonObject.Add("long", "-");
                    jsonObject.Add("objDate", "-");
                    jsonObject.Add("objKey", objKey);
                    jsonObject.Add("objType", "D");
                    jsonArray.Add(jsonObject);
                }
                JObject jObject = new JObject();
                jObject.Add("Count", jsonArray.Count);
                jObject.Add("FileCount", fileCount);
                jObject.Add("DirCount", dirCount);
                jObject.Add("Files", jsonArray);
                return jObject.ToString();
            }
            catch (BceServiceException)
            {
                throw;
            }
        }


        public String ListAllFiles(String bucketName, String dirName)
        {
            try
            {
                BosClient client = GenerateBosClient();
                List<BosObjectSummary> objects = client.ListObjects(bucketName, dirName).Contents;
                ListObjectsRequest listObjectsRequest = new ListObjectsRequest();
                listObjectsRequest.BucketName = bucketName;
                listObjectsRequest.Delimiter = delimter;
                listObjectsRequest.Prefix = dirName;
                // ListObjectsResponse response = client.ListObjects(listObjectsRequest);
                JArray jsonArray = new JArray();
                //处理文件
                foreach (BosObjectSummary obj in objects)
                {
                    String objName = obj.Key;
                    if (objName.Equals(dirName))
                    {
                        continue;
                        //objName = "../";
                    }
                    else if (dirName.Length != 0)
                    {
                        objName = objName.Replace(dirName, "");
                    }
                    String objSize = Util.formatSize(obj.Size);
                    String objDate = obj.LastModified.ToString("yyyy-MM-dd H:mm");
                    String objKey = obj.Key;
                    JObject jsonObject = new JObject();
                    jsonObject.Add("objName", objName);
                    jsonObject.Add("objSize", objSize);
                    jsonObject.Add("objDate", objDate);
                    jsonObject.Add("objKey", objKey);
                    jsonObject.Add("objType", "F");
                    jsonArray.Add(jsonObject);
                }

                return jsonArray.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public String readTxtFile(String bucketName, String objKey)
        {
            BosClient client = GenerateBosClient();
            BosObject obj = client.GetObject(bucketName, objKey);
            Stream stream = obj.ObjectContent;
            StreamReader reader = new StreamReader(stream);
            String str = reader.ReadToEnd();
            reader.Close();
            stream.Close();
            return str;
        }
        public String getFileUrl(String bucketName, String objKey)
        {
            BosClient client = GenerateBosClient();
            Uri uri = client.GeneratePresignedUrl(bucketName, objKey, 30);
            return uri.AbsoluteUri;
        }

        public void WriteFile(String bucketName, String objKey, String str)
        {
            BosClient client = GenerateBosClient();
            client.PutObject(bucketName, objKey, str);

        }

        /// <summary>
        /// 判断文件或文件夹是否存在
        /// </summary>
        /// <param name="bucketName"></param>
        /// <param name="objKey"></param>
        /// <returns></returns>
        public Boolean CheckObjExist(String bucketName, String objKey)
        {
            BosClient client = GenerateBosClient();
            ListObjectsResponse objs = client.ListObjects(bucketName, objKey);
            if (objs.Contents.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public BosObject GetObject(String bucketName, String objKey)
        {
            BosClient client = GenerateBosClient();
            BosObject obj = client.GetObject(bucketName, objKey);
            return obj;
        }

        #endregion

        /// <summary>
        /// 创建Bos链接客户端
        /// </summary>
        /// <returns></returns>
        public BosClient GenerateBosClient()
        {
            try
            {
                if (this.bosClient == null)
                {
                    // 初始化一个BosClient
                    BceClientConfiguration config = new BceClientConfiguration();
                    config.Credentials = new DefaultBceCredentials(accessKey, sccretAccessKey);
                    config.Endpoint = endpoint;
                    bosClient = new BosClient(config);
                    return bosClient;
                }
                else
                {
                    return this.bosClient;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region 文件上传
        public bool uploadFile(String filePath, String bucketName, String path)
        {
            BosClient client = GenerateBosClient();
            FileInfo fileInfo = new FileInfo(filePath);
            String fileName = fileInfo.Name;
            PutObjectResponse putObjectFromFileResponse =
                client.PutObject(bucketName, fileName, new FileInfo(filePath));

            return true;
        }

        public bool uploadFile(String filePath, String bucketName, String path, System.Windows.Forms.ToolStripProgressBar prog)
        {
            Stream fileStream = null;
            try
            {
                prog.Value = 0;
                FileInfo fileInfo = new FileInfo(filePath);
                String objectKey = path + fileInfo.Name;
                // 开始Multipart Upload
                InitiateMultipartUploadRequest initiateMultipartUploadRequest =
                    new InitiateMultipartUploadRequest() { BucketName = bucketName, Key = objectKey };
                BosClient client = GenerateBosClient();
                InitiateMultipartUploadResponse initiateMultipartUploadResponse = client.InitiateMultipartUpload(initiateMultipartUploadRequest);

                String fileName = fileInfo.Name;
                long totalSize = fileInfo.Length;
                prog.Maximum = (int)totalSize;

                long partSize = 1024 * 1024 * 20L;
                if (totalSize < this.comparisonPartSize)
                {
                    partSize = 1024 * 1024 * 1L;
                }
                int partCount = (int)(totalSize / partSize);

                if (totalSize % partSize != 0)
                {
                    partCount = partCount + 1;
                }

                // byte[] by = new byte[partSize];
                List<PartETag> partETags = new List<PartETag>();


                for (int i = 0; i < partCount; i++)
                {
                    // 获取文件流
                    fileStream = fileInfo.OpenRead();
                    // 计算每个分片跳过字节数
                    long skipBytes = partSize * i;
                    // 计算每个分块的大小
                    long size = Math.Min(partSize, fileInfo.Length - skipBytes);
                    byte[] buffer = new byte[size];
                    //跳到上次读取的开头
                    fileStream.Seek(skipBytes, SeekOrigin.Begin);
                    // fileStream.ReadAsync(buffer, 0, (int)size);

                    //分片的流
                    // MemoryStream ms = new MemoryStream(buffer);

                    // 创建UploadPartRequest，上传分块
                    UploadPartRequest uploadPartRequest = new UploadPartRequest();
                    uploadPartRequest.BucketName = bucketName;
                    uploadPartRequest.Key = path + fileInfo.Name;
                    uploadPartRequest.UploadId = initiateMultipartUploadResponse.UploadId;
                    uploadPartRequest.InputStream = fileStream;
                    uploadPartRequest.PartSize = size;
                    uploadPartRequest.PartNumber = i + 1;
                    UploadPartResponse uploadPartResponse = client.UploadPart(uploadPartRequest);
                    String eTag = uploadPartResponse.ETag;
                    while (eTag == null)
                    {
                        eTag = uploadPartResponse.ETag;
                    }
                    //标识上传成功

                    // 将返回的PartETag保存到List中。
                    partETags.Add(new PartETag()
                    {
                        ETag = uploadPartResponse.ETag,
                        PartNumber = uploadPartResponse.PartNumber
                    });
                    System.Windows.Forms.Application.DoEvents();
                    if (prog != null)
                    {
                        prog.Value = prog.Value + (int)size;
                    }
                    fileStream.Close();
                }
                // 获取UploadId的所有Upload Part
                ListPartsRequest listPartsRequest = new ListPartsRequest()
                {
                    BucketName = bucketName,
                    Key = objectKey,
                    UploadId = initiateMultipartUploadResponse.UploadId,
                };

                // 完成分块上传
                CompleteMultipartUploadRequest completeMultipartUploadRequest =
                    new CompleteMultipartUploadRequest()
                    {
                        BucketName = bucketName,
                        Key = objectKey,
                        UploadId = initiateMultipartUploadResponse.UploadId,
                        PartETags = partETags
                    };
                CompleteMultipartUploadResponse completeMultipartUploadResponse =
                    client.CompleteMultipartUpload(completeMultipartUploadRequest);
                return true;
            }
            catch (BceServiceException)
            {
                throw;
            }
            catch (BceClientException)
            {
                throw;
            }
            finally
            {
                if (fileStream != null)
                {
                    // 关闭文件
                    fileStream.Close();
                    fileStream = null;
                }
            }
        }
        #endregion

        public bool Download1(String bucketName, String key, String fileName, String path)
        {
            // 新建GetObjectRequest
            GetObjectRequest getObjectRequest = new GetObjectRequest() { BucketName = bucketName, Key = key };
            BosClient client = this.GenerateBosClient();
            // 下载Object到文件
            ObjectMetadata objectMetadata = client.GetObject(getObjectRequest, new FileInfo(path + "/" + fileName));
            return true;
        }
        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="bucketName"></param>
        /// <param name="path"></param>
        /// <param name="folderName"></param>
        /// <returns></returns>
        public bool CreateFolder(String bucketName, String path, String folderName)
        {
            path = path + folderName + "/";
            BosClient client = this.GenerateBosClient();
            PutObjectResponse putObjectFromFileResponse =
              client.PutObject(bucketName, path, "");
            return true;
        }

        public bool DeleteObject(String bucketName, String sourceKey)
        {
            try
            {
                BosClient client = this.GenerateBosClient();
                //当是文件夹的时候
                if (sourceKey.EndsWith(this.delimter))
                {
                    String filter = sourceKey.Substring(0, sourceKey.Length - 1);
                    if (filter.IndexOf(this.delimter) >= 0)
                    {
                        filter = sourceKey.Substring(0, filter.IndexOf(this.delimter)) + this.delimter;
                    }
                    else
                    {
                        filter = String.Empty;
                    }
                    ListObjectsResponse response = client.ListObjects(bucketName, sourceKey);
                    foreach (BosObjectSummary obj in response.Contents)
                    {
                        String key = obj.Key;
                        client.DeleteObject(bucketName, key);
                    }
                }
                else
                {
                    String fileName = sourceKey;
                    client.DeleteObject(bucketName, sourceKey);
                }
                return true;
            }
            catch (BceServiceException)
            {
                throw;
            }
        }

        public void RemoveAllMultiUploads(String bucketName)
        {
            BosClient client = this.GenerateBosClient();
            ListMultipartUploadsResponse list = client.ListMultipartUploads(bucketName);

            foreach (MultipartUploadSummary summary in list.Uploads)
            {
                String uploadID = summary.UploadId;
                String key = summary.Key;
                String name = summary.Owner.DisplayName;

                client.AbortMultipartUpload(bucketName, key, uploadID);
                String sss = "";
            }
        }

        public bool CutFile(String bucketName, String sourceKey, String targetPath)
        {
            try
            {


                BosClient client = this.GenerateBosClient();
                //当是文件的时候
                if (sourceKey.EndsWith(this.delimter))
                {
                    String filter = sourceKey.Substring(0, sourceKey.Length - 1);
                    if (filter.IndexOf(this.delimter) >= 0)
                    {
                        filter = sourceKey.Substring(0, filter.IndexOf(this.delimter)) + this.delimter;
                    }
                    else
                    {
                        filter = String.Empty;
                    }
                    ListObjectsResponse response = client.ListObjects(bucketName, sourceKey);
                    foreach (BosObjectSummary obj in response.Contents)
                    {
                        String key = obj.Key;
                        String newKey = "";
                        if (filter.Length == 0)
                        {
                            newKey = targetPath + key;
                        }
                        else
                        {
                            newKey = targetPath + key.Replace(filter, "");
                        }
                        client.CopyObject(bucketName, key, bucketName, newKey);
                        client.DeleteObject(bucketName, key);

                    }
                }
                else
                {
                    String fileName = sourceKey;
                    if (sourceKey.IndexOf(this.delimter) >= 0)
                    {
                        fileName = sourceKey.Substring(sourceKey.IndexOf(this.delimter));
                    }
                    String newKey = targetPath + fileName;
                    client.CopyObject(bucketName, sourceKey, bucketName, newKey);
                    client.DeleteObject(bucketName, sourceKey);
                }
                // client.CopyObject();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool CopyFile(String bucketName, String sourceKey, String targetPath)
        {
            try
            {

                BosClient client = this.GenerateBosClient();
                //当是文件夹的时候
                if (sourceKey.EndsWith(this.delimter))
                {
                    String filter = sourceKey.Substring(0, sourceKey.Length - 1);
                    if (filter.IndexOf(this.delimter) >= 0)
                    {
                        filter = sourceKey.Substring(0, filter.LastIndexOf(this.delimter)) + this.delimter;
                    }
                    else
                    {
                        filter = String.Empty;
                    }
                    ListObjectsResponse response = client.ListObjects(bucketName, sourceKey);
                    foreach (BosObjectSummary obj in response.Contents)
                    {
                        String key = obj.Key;
                        String newKey = "";
                        if (filter.Length == 0)
                        {
                            newKey = targetPath + key;
                        }
                        else
                        {
                            newKey = targetPath + key.Replace(filter, "");
                        }
                        client.CopyObject(bucketName, key, bucketName, newKey);

                    }
                }
                else
                {
                    String fileName = sourceKey;
                    if (sourceKey.IndexOf(this.delimter) >= 0)
                    {
                        fileName = sourceKey.Substring(sourceKey.IndexOf(this.delimter));
                    }
                    String newKey = targetPath + fileName;
                    client.CopyObject(bucketName, sourceKey, bucketName, newKey);
                }
                // client.CopyObject();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 取得路径下所有的文件夹信息
        /// </summary>
        /// <param name="bucketName"></param>
        /// <param name="dirName"></param>
        /// <returns></returns>
        public String ListDirOnlyDir(String bucketName, String dirName)
        {
            try
            {
                BosClient client = GenerateBosClient();
                ListObjectsRequest listObjectsRequest = new ListObjectsRequest();
                listObjectsRequest.BucketName = bucketName;
                listObjectsRequest.Delimiter = delimter;
                listObjectsRequest.Prefix = dirName;
                ListObjectsResponse response = client.ListObjects(listObjectsRequest);
                JArray jsonArray = new JArray();

                //处理文件夹
                foreach (ObjectPrefix obj in response.CommonPrefixes)
                {
                    String objName = obj.Prefix;
                    if (objName.Equals(dirName))
                    {
                        continue;
                        //objName = "../";
                    }
                    else if (dirName.Length != 0)
                    {
                        objName = objName.Replace(dirName, "");
                    }
                    String objKey = obj.Prefix;
                    JObject jsonObject = new JObject();
                    jsonObject.Add("objName", objName);
                    jsonObject.Add("objSize", "-");
                    jsonObject.Add("objDate", "-");
                    jsonObject.Add("objKey", objKey);
                    jsonObject.Add("objType", "D");
                    jsonArray.Add(jsonObject);
                }
                return jsonArray.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 取得路径下所有文件的信息，不包括文件夹
        /// </summary>
        /// <param name="bucketName"></param>
        /// <param name="dirName"></param>
        /// <returns></returns>
        public String ListDirOnlyFile(String bucketName, String dirName)
        {
            try
            {
                BosClient client = GenerateBosClient();
                ListObjectsRequest listObjectsRequest = new ListObjectsRequest();
                listObjectsRequest.BucketName = bucketName;
                listObjectsRequest.Delimiter = delimter;
                listObjectsRequest.Prefix = dirName;
                ListObjectsResponse response = client.ListObjects(listObjectsRequest);
                JArray jsonArray = new JArray();
                //处理文件
                foreach (BosObjectSummary obj in response.Contents)
                {
                    String objName = obj.Key;
                    if (objName.Equals(dirName))
                    {
                        continue;
                        //objName = "../";
                    }
                    else if (dirName.Length != 0)
                    {
                        objName = objName.Replace(dirName, "");
                    }
                    String objSize = Util.formatSize(obj.Size);
                    String objDate = obj.LastModified.ToString("yyyy-MM-dd H:mm");
                    String objKey = obj.Key;
                    JObject jsonObject = new JObject();
                    jsonObject.Add("objName", objName);
                    jsonObject.Add("objSize", objSize);
                    jsonObject.Add("objDate", objDate);
                    jsonObject.Add("objKey", objKey);
                    jsonObject.Add("objType", "F");
                    jsonArray.Add(jsonObject);
                }

                return jsonArray.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Write()
        {
            BosClient client = GenerateBosClient();
            BosObject obj = client.GetObject("", "");
            // obj.ObjectContent

        }
    }
}

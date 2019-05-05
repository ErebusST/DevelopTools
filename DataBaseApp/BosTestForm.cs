using BaiduBce.Services.Bos.Model;
using CreateProject.Util;
using DataBaseApp;
using Gooal.Model.BaseTable.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CreateProject
{
    public partial class BosTestForm : Form
    {
        public BosTestForm()
        {
            InitializeComponent();
        }


        private void BosTestForm_Load(object sender, EventArgs e)
        {

            try
            {
                initBucketDropDown();
                toolStripStatusLabel2.Text = "";
                toolStripStatusLabel3.Text = "";
                toolStripStatusLabel4.Text = "";
                toolStripStatusLabel5.Text = "";
                initFiles("");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void initBucketDropDown()
        {
            BosUtil bosUtil = new BosUtil();
            List<BucketSummary> buckets = bosUtil.getBucketList();
            foreach (BucketSummary bucket in buckets)
            {
                String bucketName = bucket.Name;
                ToolStripMenuItem item = new ToolStripMenuItem();

                item.Name = bucketName;
                item.Size = new System.Drawing.Size(152, 22);
                item.Text = bucketName;
                this.ddSelectBucket.DropDownItems.Add(item);
                item.Click += toolStripMenuItem_Click;

            }
            ToolStripMenuItem selectedItem = ddSelectBucket.DropDownItems[0] as ToolStripMenuItem;
            selectedItem.CheckState = CheckState.Checked;
            lbSelectedBucket.Text = "选中的Bucket:" + selectedItem.Name;
        }


        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem selectedItem = sender as ToolStripMenuItem;
                selectedItem.CheckState = CheckState.Checked;
                String selectedBucketName = selectedItem.Name;
                lbSelectedBucket.Text = "选中的Bucket:" + selectedBucketName;
                initFiles("");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void initFiles(String filter)
        {
            if (filter.Length != 0)
            {
                lbPath.Text = filter;
                btbBack.Enabled = true;
            }
            else
            {
                lbPath.Text = "根目录";
                btbBack.Enabled = false;
            }

            BosUtil bosUtil = new BosUtil();
            String selectedBucketName = lbSelectedBucket.Text.Replace("选中的Bucket:", "");
            Boolean isExist = bosUtil.checkBucketExist(selectedBucketName);
            DataTable objDT = getDataStruct().Clone();
            if (isExist)
            {
                ListObjectsResponse response = bosUtil.getObjectsList(selectedBucketName, filter);


                foreach (BosObjectSummary obj in response.Contents)
                {
                    String objName = obj.Key;
                    long size = obj.Size;
                    DateTime time = obj.LastModified;
                    String key = obj.Key;
                    if (objName.Equals(filter))
                    {
                        continue;
                        //objName = "../";
                    }
                    else if (filter.Length != 0)
                    {
                        objName = objName.Replace(filter, "");
                    }
                    DataRow newRow = objDT.NewRow();
                    newRow[objNameStr] = objName;
                    newRow[sizeStr] = Util.Util.formatSize(size);
                    newRow["s2"] = size;
                    newRow[dateStr] = time.ToString("yyyy-MM-dd H:mm");
                    newRow[objTypeStr] = fileType;
                    newRow[keyStr] = key;
                    objDT.Rows.Add(newRow);
                }

                foreach (ObjectPrefix obj in response.CommonPrefixes)
                {
                    String objName = obj.Prefix;
                    DataRow newRow = objDT.NewRow();
                    String key = objName;

                    if (objName.Equals(filter))
                    {
                        continue;
                        //objName = "../";
                    }
                    else if (filter.Length != 0)
                    {
                        objName = objName.Replace(filter, "");
                    }
                    newRow[objNameStr] = objName;
                    newRow[sizeStr] = "-";
                    newRow[dateStr] = "-";
                    newRow[objTypeStr] = directoryType;
                    newRow[keyStr] = key;
                    objDT.Rows.Add(newRow);
                }
            }
            gvData.AutoGenerateColumns = false;
            gvData.DataSource = objDT;
        }

        private DataTable getDataStruct()
        {
            DataTable objDT = new DataTable();
            objDT.Columns.Add(objNameStr);
            objDT.Columns.Add(sizeStr);
            objDT.Columns.Add(dateStr);
            objDT.Columns.Add(objTypeStr);
            objDT.Columns.Add(keyStr);
            objDT.Columns.Add("s2");
            return objDT;
        }

        private String objNameStr = "ObjName";
        private String sizeStr = "Size";
        private String dateStr = "Date";
        private String objTypeStr = "objType";
        private String keyStr = "KEY";
        private String fileType = "F";
        private String directoryType = "D";


        private void gvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                int colIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void gvData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //int rowIndex = e.RowIndex;
            //DataGridView gv = sender as DataGridView;
            //DataTable tempDT = gv.DataSource as DataTable;

            //String type = Util.Util.ConvertObjToString(tempDT.Rows[rowIndex][objTypeStr]);
            //if (type.Equals(directoryType))
            //{
            //    Type t = gvData.Rows[rowIndex].Cells[objNameStr].EditType;
            //    Object value = tempDT.Rows[rowIndex][objNameStr];
            //    gvData.Rows[rowIndex].Cells[objNameStr].Value = "<a>" + value+"</a>";
            //}

        }

        private void gvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gvData.Columns[e.ColumnIndex].Name.Equals("ObjName"))
                {
                    int rowIndex = e.RowIndex;
                    DataGridView gv = sender as DataGridView;
                    String type = Util.Util.ConvertObjToString(gv.Rows[rowIndex].Cells[objTypeStr].Value);
                    if (type.Equals(directoryType))
                    {
                        String key = Util.Util.ConvertObjToString(gv.Rows[rowIndex].Cells[keyStr].Value);
                        initFiles(key);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                String selectedBucketName = lbSelectedBucket.Text.Replace("选中的Bucket:", "");
                UploadForm uf = new UploadForm();
                uf.BucketName = selectedBucketName;
                uf.SelectedPath = lbPath.Text.Replace("根目录", "");
                uf.ShowDialog();
                initFiles(lbPath.Text.Replace("根目录", ""));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtFolderName.Visible)
                {
                    txtFolderName.Visible = true;
                    btnCreateFolder.Text = "取消(&C)";
                }
                else
                {
                    txtFolderName.Visible = false;
                    btnCreateFolder.Text = "新建文件夹(&C)";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenText_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewSelectedRowCollection selectedRows = this.gvData.SelectedRows;
                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("请选择！");
                    return;
                }
                else if (selectedRows.Count > 1)
                {
                    MessageBox.Show("只能选择一行！");
                    return;
                }
                String type = Util.Util.ConvertObjToString(selectedRows[0].Cells[objTypeStr].Value);
                if (type.Equals(this.directoryType))
                {
                    MessageBox.Show("选择的是文件夹！");
                    return;
                }
                String bosUri = Util.Util.ConvertObjToString(selectedRows[0].Cells[this.keyStr].Value);
                String selectedBucketName = lbSelectedBucket.Text.Replace("选中的Bucket:", "");
                ReadForm readForm = new ReadForm();
                readForm.Key = bosUri;
                readForm.SelectedBucket = selectedBucketName;
                readForm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection selectedRows = this.gvData.SelectedRows;
                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("请选择！");
                    return;
                }
                else if (selectedRows.Count > 1)
                {
                    MessageBox.Show("只能选择一行！");
                    return;
                }
                String type = Util.Util.ConvertObjToString(selectedRows[0].Cells[objTypeStr].Value);
                if (type.Equals(this.directoryType))
                {
                    MessageBox.Show("选择的是文件夹！");
                    return;
                }
                String bosUri = Util.Util.ConvertObjToString(selectedRows[0].Cells[this.keyStr].Value);
                String fileName = Util.Util.ConvertObjToString(selectedRows[0].Cells[this.objNameStr].Value);
                String selectedBucketName = lbSelectedBucket.Text.Replace("选中的Bucket:", "");
                BosUtil bosUtil = new BosUtil();
                String uriPath = bosUtil.getFileUrl(selectedBucketName, bosUri);
                DownloadUtil downloadUtil = new DownloadUtil();
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = fileName;
                DialogResult result = sfd.ShowDialog();
                String path = sfd.FileName;
                if (result.Equals(DialogResult.OK))
                {
                    downloadUtil.DownloadFile(uriPath, path, pbProcess);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtFolderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter && txtFolderName.Text.Trim().Length != 0)
                {
                    String folderName = txtFolderName.Text.Trim();
                    String bucketName = lbSelectedBucket.Text.Replace("选中的Bucket:", "");
                    String path = lbPath.Text.Replace("根目录", "");
                    BosUtil bosUtil = new BosUtil();
                    bosUtil.CreateFolder(bucketName, path, folderName);
                    txtFolderName.Clear();
                    txtFolderName.Visible = false;
                    this.initFiles(path);
                    txtFolderName.Visible = false;
                    btnCreateFolder.Text = "新建文件夹(&C)";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btbBack_Click(object sender, EventArgs e)
        {

            try
            {
                String path = lbPath.Text.Replace("根目录", "");
                String[] pathArr = path.Split(new Char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                path = "";
                for (int i = 0; i < pathArr.Length - 1; i++)
                {
                    path = path + pathArr[i] + "/";
                }
                this.initFiles(path);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        private void btn_ClearMuPartsInfo_Click(object sender, EventArgs e)
        {
            try
            {
                BosUtil bosUtil = new BosUtil();
                String path = lbPath.Text.Replace("根目录", "");
                String selectedBucketName = lbSelectedBucket.Text.Replace("选中的Bucket:", "");

                //tring key = "Kong1212/";
                bosUtil.RemoveAllMultiUploads(selectedBucketName);
                //  bool isE = bosUtil.CheckFileExist(selectedBucketName, key);
                this.initFiles(path);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDownload1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection selectedRows = this.gvData.SelectedRows;
                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("请选择！");
                    return;
                }
                else if (selectedRows.Count > 1)
                {
                    MessageBox.Show("只能选择一行！");
                    return;
                }
                String type = Util.Util.ConvertObjToString(selectedRows[0].Cells[objTypeStr].Value);
                if (type.Equals(this.directoryType))
                {
                    MessageBox.Show("选择的是文件夹！");
                    return;
                }
                String bosUri = Util.Util.ConvertObjToString(selectedRows[0].Cells[this.keyStr].Value);
                String fileName = Util.Util.ConvertObjToString(selectedRows[0].Cells[this.objNameStr].Value);
                long size = long.Parse(selectedRows[0].Cells["s2"].Value.ToString());
                String selectedBucketName = lbSelectedBucket.Text.Replace("选中的Bucket:", "");
                BosUtil bosUtil = new BosUtil();
                String uriPath = bosUtil.getFileUrl(selectedBucketName, bosUri);
                DownloadUtil downloadUtil = new DownloadUtil();
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = fileName;
                DialogResult result = sfd.ShowDialog();
                String path = sfd.FileName;

                if (result.Equals(DialogResult.OK))
                {
                    DateTime startTime = DateTime.Now;
                    String start = startTime.ToString();
                    this.toolStripStatusLabel2.Text = "开始时间:" + start + "|";
                    bosUtil.Download1(selectedBucketName, bosUri, fileName, path);
                    DateTime endTime = DateTime.Now;
                    String end = endTime.ToString();
                    this.toolStripStatusLabel3.Text = "结束时间:" + end + "|";
                    TimeSpan tsStart = new TimeSpan(startTime.Ticks);
                    TimeSpan tsEnd = new TimeSpan(endTime.Ticks);
                    TimeSpan ts = tsEnd.Subtract(tsStart).Duration();
                    int dateDiffSecond = ts.Days * 24 * 60 * 60 + ts.Hours * 60 * 60 + ts.Minutes * 60 + ts.Seconds;
                    this.toolStripStatusLabel4.Text = "耗时:" + dateDiffSecond.ToString() + "|";
                    //两个时间的秒差
                    long speed = size / 1024 / dateDiffSecond;
                    this.toolStripStatusLabel5.Text = "速度:" + speed.ToString() + "M/s";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Cut_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection selectedRows = this.gvData.SelectedRows;
                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("请选择！");
                    return;
                }
                String targetPath = txtCutPath.Text;
                if (targetPath.Trim().Length == 0)
                {
                    MessageBox.Show("请填写目标路径！");
                    return;
                }
                String selectedBucketName = lbSelectedBucket.Text.Replace("选中的Bucket:", "");
                BosUtil bosUtil = new BosUtil();
                foreach (DataGridViewRow row in selectedRows)
                {
                    String key = row.Cells[this.keyStr].Value.ToString();
                    bosUtil.CutFile(selectedBucketName, key, targetPath);
                }
                initFiles(lbPath.Text.Replace("根目录", ""));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection selectedRows = this.gvData.SelectedRows;
                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("请选择！");
                    return;
                }
                BosUtil bosUtil = new BosUtil();
                String selectedBucketName = lbSelectedBucket.Text.Replace("选中的Bucket:", "");
                foreach (DataGridViewRow row in selectedRows)
                {
                    String key = row.Cells[this.keyStr].Value.ToString();
                    bosUtil.DeleteObject(selectedBucketName, key);
                }
                initFiles(lbPath.Text.Replace("根目录", ""));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection selectedRows = this.gvData.SelectedRows;
                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("请选择！");
                    return;
                }
                String targetPath = txtCutPath.Text;
                if (targetPath.Trim().Length == 0)
                {
                    MessageBox.Show("请填写目标路径！");
                    return;
                }
                String selectedBucketName = lbSelectedBucket.Text.Replace("选中的Bucket:", "");
                BosUtil bosUtil = new BosUtil();
                foreach (DataGridViewRow row in selectedRows)
                {
                    String key = row.Cells[this.keyStr].Value.ToString();
                    bosUtil.CopyFile(selectedBucketName, key, targetPath);
                }
                initFiles(lbPath.Text.Replace("根目录", ""));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

        private string GetSqlStr(String uid, String uName, String fileName, String size, String sizeLong, String key, String wjfl, String czsj)
        {

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO ");
            sbSql.Append("   [XT_WODEWENJIAN]([WJID], ");
            sbSql.Append("   [YHID], ");
            sbSql.Append("   [UserFileName], ");
            sbSql.Append("   [BUCKETNAME], ");
            sbSql.Append("   [FILEKEY], ");
            sbSql.Append("   [SFSYZ], ");
            sbSql.Append("   [WJFL], ");
            sbSql.Append("   [WJLY], ");
            sbSql.Append("   [SXLX], ");
            sbSql.Append("   [BZ], ");
            sbSql.Append("   [CJSJ], ");
            sbSql.Append("   [SIZE], ");
            sbSql.Append("   [CZR], ");
            sbSql.Append("   [SIZELong], ");
            sbSql.Append("   [CZSJ]) ");
            sbSql.Append(" VALUES ");
            sbSql.Append("   ('" + Guid.NewGuid().ToString() + "', ");
            sbSql.Append("   '" + uid + "', ");
            sbSql.Append("   '" + fileName + "', ");
            sbSql.Append("   'testbos1', ");
            sbSql.Append("   '" + key + "', ");
            sbSql.Append("   '0', ");
            sbSql.Append("   '" + wjfl + "', ");
            sbSql.Append("   'PROJECTFILES', ");
            sbSql.Append("   '1', ");
            sbSql.Append("   '', ");
            sbSql.Append("   '" + czsj + "', ");
            sbSql.Append("   '" + size + "', ");
            sbSql.Append("   '" + uName + "', ");
            sbSql.Append("   '" + sizeLong + "', ");
            sbSql.Append("   '" + czsj + "'); ");
            return sbSql.ToString();

        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {

            String path = lbPath.Text.Replace("根目录", "");
            this.initFiles(path);
        }

      


        private string GetFolderSqlStr(String uid, String fileName, String key, String wjly)
        {

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO ");
            sbSql.Append("   [XT_WODEWENJIAN]([WJID], ");
            sbSql.Append("   [YHID], ");
            sbSql.Append("   [UserFileName], ");
            sbSql.Append("   [BUCKETNAME], ");
            sbSql.Append("   [FILEKEY], ");
            sbSql.Append("   [SFSYZ], ");
            sbSql.Append("   [WJFL], ");
            sbSql.Append("   [WJLY], ");
            sbSql.Append("   [SXLX], ");
            sbSql.Append("   [BZ], ");
            sbSql.Append("   [CJSJ], ");
            sbSql.Append("   [SIZE], ");
            sbSql.Append("   [CZR], ");
            // sbSql.Append("   [SIZELong], ");
            sbSql.Append("   [CZSJ]) ");
            sbSql.Append(" VALUES ");
            sbSql.Append("   ('" + Guid.NewGuid().ToString() + "', ");
            sbSql.Append("   '" + uid + "', ");
            sbSql.Append("   '" + fileName + "', ");
            sbSql.Append("   'testbos1', ");
            sbSql.Append("   '" + key + "', ");
            sbSql.Append("   '0', ");
            sbSql.Append("   'D', ");
            sbSql.Append("   '" + wjly + "', ");
            sbSql.Append("   '', ");
            sbSql.Append("   '', ");
            sbSql.Append("   '" + DateTime.Now.ToString() + "', ");
            sbSql.Append("   '', ");
            sbSql.Append("   'master', ");
            // sbSql.Append("   '" + sizeLong + "', ");
            sbSql.Append("   '" + DateTime.Now.ToString() + "'); ");
            return sbSql.ToString();

        }

        private void BosTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.bosTestForm = null;
        }
    }


}

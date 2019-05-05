using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Gooal.Model.BaseTable.Entity{
	 	//XT_WoDeWenJian
		public class XT_WoDeWenJianEntity
	{
   		     
      	/// <summary>
		/// WJID
        /// </summary>		
        public string WJID{ get;set; }        
		/// <summary>
		/// YHID
        /// </summary>		
        public string YHID{ get;set; }        
		/// <summary>
		/// UserFileName
        /// </summary>		
        public string UserFileName{ get;set; }        
		/// <summary>
		/// BucketName
        /// </summary>		
        public string BucketName{ get;set; }        
		/// <summary>
		/// FILEKEY
        /// </summary>		
        public string FILEKEY{ get;set; }
        /// <summary>
        /// FileKeyInBos
        /// </summary>
        public String FileKeyInBos { get; set; }
        /// <summary>
        /// SFSYZ
        /// </summary>		
        public string SFSYZ{ get;set; }        
		/// <summary>
		/// WJFL
        /// </summary>		
        public string WJFL{ get;set; }        
		/// <summary>
		/// WJLY
        /// </summary>		
        public string WJLY{ get;set; }

        private String _SXLX = String.Empty;
        /// <summary>
        /// SXLX
        /// </summary>		
        public string SXLX
        {
            get { return _SXLX; }
            set { _SXLX = value; }
        }

        private String _BZ = String.Empty;    
		/// <summary>
		/// BZ
        /// </summary>		
        public string BZ
        {
            get { return _BZ; }
            set { _BZ = value; }
        }
             
		/// <summary>
		/// CJSJ
        /// </summary>		
        public String CJSJ{ get;set; }        
		/// <summary>
		/// SIZE
        /// </summary>		
        public string SIZE{ get;set; }        
		/// <summary>
		/// CZR
        /// </summary>		
        public string CZR{ get;set; }        
		/// <summary>
		/// CZSJ
        /// </summary>		
        public String CZSJ { get;set; }
        public String _SIZELong = "0";
        /// <summary>
        /// SIZELong
        /// </summary>		
        public String SIZELong
        {
            get { return _SIZELong; }
            set { _SIZELong = value; }
        }     
           
		   
	}
}
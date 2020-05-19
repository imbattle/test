using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prjModelValidate.Models.ModelMetaData
{
    [MetadataType(typeof(tStudentMetaData))]
    public class tStudent
    {
        private class tStudentMetaData
        {
            [DisplayName("學號")]
            [Required(ErrorMessage = "學號不可空白！！")]
            [StringLength(7, MinimumLength = 2, ErrorMessage = "學號必須是2-7個字元！！")]
            public string fStuId { get; set; }
            [DisplayName("姓名")]
            [Required(ErrorMessage = "姓名不可空白！！")]
            public string fName { get; set; }
            [DisplayName("信箱")]
            [EmailAddress(ErrorMessage = "E-Mail 格式有誤！！")]
            public string fEmail { get; set; }
            [DisplayName("成績")]
            [Range(0, 100, ErrorMessage = "分數必須是0-100！！")]
            public Nullable<int> fScore { get; set; }
        }
    }
}
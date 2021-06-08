using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ActionFilters.Models
{
    [Table("Logs")]
    public class Log
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,DisplayName("İşlem tarihi")]
        public DateTime TransactionDate { get; set; }

        [Required,StringLength(20),DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required, StringLength(100), DisplayName("Action")]
        public string ActionName { get; set; }

        [Required, StringLength(100), DisplayName("Controller")]
        public string ControllerName { get; set; }
    }
}
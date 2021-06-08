using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ActionFilters.Models
{
    [Table("SiteUsers")]
    public class SiteUser
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,StringLength(20),DisplayName("Ad")]
        public string Name { get; set; }

        [Required, StringLength(20), DisplayName("SoyAd")]
        public string SurName { get; set; }

        [Required, StringLength(20), DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "The service name is required")]
        [Display(Name = "Service name(title)")]
        public override string Title { get; set; }

        [Display(Name = "Short service description")]
        public override string Subtitle { get; set; }

        [Display(Name = "Full service description")]
        public override string Text { get; set; }
    }
}

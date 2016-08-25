﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ImageSharingWithCloudService.Models;
using System.Runtime.Serialization;


namespace ImageSharingWithCloudService.Models
{
    
    public class Image
    /*
    * Entity model for an image
    */
    {
        [Key]
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        
        [MaxLength(40)]
        public virtual string Caption { get; set; }
        
        [MaxLength(200)]
        public virtual String Description { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateTaken { get; set; }
        
        public virtual bool Approved { get; set; }
        
        public virtual bool Validated { get; set; }

        [ForeignKey("User")]
        
        public virtual string UserId { get; set; }
        //public virtual User User { get; set; }
        
        public virtual ApplicationUser User { get; set; }

        [ForeignKey("Tag")]
       
        public virtual int TagId { get; set; }
        
        public virtual Tag Tag { get; set; }

        
        //public Image()
        //{
        //    Validated = false;
        //    Approved =  false;
        //}
    }
}
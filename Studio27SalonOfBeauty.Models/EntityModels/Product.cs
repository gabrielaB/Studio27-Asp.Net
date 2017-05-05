using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Net.Mime;
using System.Drawing;
using Studio27SalonOfBeauty.Models.EntityModels.Enums;


namespace Studio27SalonOfBeauty.Models.EntityModels
{
    public class Product
    {
       
        [Key]
        public int Id { get; set; }
        public string ProductImage { get; set; }

        public string Name { get; set; }

        public static string SetImage(string path)
        {
            byte[] imageArray = File.ReadAllBytes(path);
            //return imageArray;
            string base64ImageRepresentation = Convert.ToBase64String(imageArray);
            return base64ImageRepresentation;
        }
    
        public string Description { get; set; }
        public ProductCategory Category { get; set; }


       

    }
}

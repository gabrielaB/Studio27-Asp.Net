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

        [Required(ErrorMessage = "Product's name is mandatory")]
        [DataType(DataType.Text)]
        [MaxLength(30, ErrorMessage = "Maximum name length is 30 symbols")]
        [MinLength(2, ErrorMessage = "Minimum name length is 2 symbols")]
        public string Name { get; set; }
    
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(150,ErrorMessage ="Maximum description lenght is 150 symbols")]
        [MinLength(3, ErrorMessage = "Minimum description lenght is 3 symbols")]
        public string Description { get; set; }
        public ProductCategory Category { get; set; }


        public static string SetImage(string path)
        {
            byte[] imageArray = File.ReadAllBytes(path);
            //return imageArray;
            string base64ImageRepresentation = Convert.ToBase64String(imageArray);
            return base64ImageRepresentation;
        }

    }
}

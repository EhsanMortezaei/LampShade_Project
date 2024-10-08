﻿using _0_Framework.Domain;
using ShopManagement.Domain.ProductCategoryAgg;
using ShopManagement.Domain.ProductPictureAgg;
using System.Collections.Generic;

namespace ShopManagement.Domain.ProductAgg
{
    public class Product : EntityBase
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        public string ShortDescription { get; private set; }
        public string Descrption { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public long CategoryId { get; private set; }
        public string Slug { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public ProductCategory Category { get; private set; }
        public List<ProductPicture> ProductPictures { get; private set; }

        public Product(string name, string code, string shortDescription, string descrption,
            string picture, string pictureAlt, string pictureTitle,
            long categoryId, string slug, string keywords, string metaDescription)
        {
            Name = name;
            Code = code;
            ShortDescription = shortDescription;
            Descrption = descrption;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            CategoryId = categoryId;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
        }

        public void Edit(string name, string code, string shortDescription, string descrption,
            string picture, string pictureAlt, string pictureTitle,
            long categoryId, string slug, string keywords, string metaDescription)
        {
            Name = name;
            Code = code;
            ShortDescription = shortDescription;
            Descrption = descrption;
            if (!string.IsNullOrEmpty(picture))
            {
                Picture = picture;
            }
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            CategoryId = categoryId;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
        }
    }
}

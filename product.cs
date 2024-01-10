using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi
{
    public  class product
    {
        private string id;
        private string title;
        private string description;
        private string price;
        private string discountPercentage;
        private string rating;
        private string stock;
        private string brand;
        private string category;
        private string thumbnail;
        private string img0;
        private string img1;
        private string img2;
        private string img3;
        private string img4;

        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Price { get => price; set => price = value; }
        public string DiscountPercentage { get => discountPercentage; set => discountPercentage = value; }
        public string Rating { get => rating; set => rating = value; }
        public string Stock { get => stock; set => stock = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Category { get => category; set => category = value; }
        public string Thumbnail { get => thumbnail; set => thumbnail = value; }
        public string Img0 { get => img0; set => img0 = value; }
        public string Img1 { get => img1; set => img1 = value; }
        public string Img2 { get => img2; set => img2 = value; }
        public string Img3 { get => img3; set => img3 = value; }
        public string Img4 { get => img4; set => img4 = value; }
    }
}

﻿// Category Entity

namespace ByteBakes.Models.Categories
{
    public class Category
    {
        public int ID { get; set; }


        public string Name { get; set; }

        // Function to get category type
        public string Type { get; set; }

        //Adding this here
        public string CategoryName {  get; set; }
    }
}

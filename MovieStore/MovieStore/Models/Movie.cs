﻿using MovieStore.Infrastructure;
namespace MovieStore.Models
{
    public class Movie: BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}
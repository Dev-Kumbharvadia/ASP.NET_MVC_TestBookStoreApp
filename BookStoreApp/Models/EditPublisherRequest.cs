﻿namespace BookStoreApp.Models
{
    public class EditPublisherRequest
    {
        public Guid Id { get; set; }  // Unique identifier for the publisher
        public string Name { get; set; }  // Name of the publisher
    }
}

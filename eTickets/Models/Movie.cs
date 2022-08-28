using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;

namespace eTickets.Models
{
    public class Movie : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price{ get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory{ get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
        public Cinema Cinema { get; set; }
        public int CinemaId { get; set; }
        public Producer Producer { get; set; }
        public int ProducerId { get; set; }


    }
}

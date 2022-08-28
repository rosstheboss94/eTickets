using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class NewMovieVM 
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Movie name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Movie Name")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Movie price")]
        public double Price{ get; set; }

        [Required(ErrorMessage = "Movie poster URL is required")]
        [Display(Name = "Movie poster URL")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Start date is required")]
        [Display(Name = "Start date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        [Display(Name = "End date")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Movie category is required")]
        [Display(Name = "Select a category")]
        public MovieCategory MovieCategory{ get; set; }

        //Relationships
        [Required(ErrorMessage = "Movie actor(s) is required")]
        [Display(Name = "Select actor(s)")]
        public List<int> ActorIds { get; set; }

        [Required(ErrorMessage = "Movie cinema is required")]
        [Display(Name = "Select a cinema")]
        public int CinemaId { get; set; }

        [Required(ErrorMessage = "Producer is required")]
        [Display(Name = "Select a producer")]
        public int ProducerId { get; set; }


    }
}

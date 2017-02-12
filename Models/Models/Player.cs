using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Tournaments.Models
{
    public class Player : IdentityUser, IPlayer
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }

        //[Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Picture { get; set; }
        //public string Email { get; set; }
        public double Rating { get; set; }
        public bool IsCoach { get; set; }
        public string CV { get; set; }
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }

        public ClaimsIdentity GenerateUserIdentity(UserManager<Player> manager)
        {
            // note the authenticationtype must match the one defined in cookieauthenticationoptions.authenticationtype
            var useridentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
            // add custom user claims here
            return useridentity;
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Player> manager)
        {
            return Task.FromResult(GenerateUserIdentity(manager));
        }
    }
}
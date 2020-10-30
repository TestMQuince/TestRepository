using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MQuince.Repository.SQL.PersistenceEntities
{

    //Anotacija ispod [Table("User")] u EntityFrameworku pomocu koje se zadaje naziv tabele, ova klasa se pravi da se u Entitetima ne bi mesale anotacije, 
    //jer se tad krsi singular responsibility princip
    [Table("User")]
    public class UserPersistence
    {
        [Key] //Anotacija za primarni kljuc 
        public Guid Id { get; set; }
        [Required]//Anotacija pomocu koje se ogranicava tabela da se ne moze proslediti null za username
        public string Username { get; set; }
    }
}

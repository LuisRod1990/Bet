using System.ComponentModel.DataAnnotations;

namespace API.Bet.ViewModel
{
    public class VMPlayer
    {
        [Key]
        public int IDIn { get; set; }
        public string? PlayerNameVc{ get; set; }
        public DateTime BirthDateDt { get; set; }
        public string? NationalityVc { get; set; }
        public string? PicturePathVc { get; set; }
        public bool Activo { get; set; }

    }
}

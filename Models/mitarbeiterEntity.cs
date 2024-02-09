using System.ComponentModel.DataAnnotations;

namespace datenbanken2.Models
{
    public class mitarbeiterEntity
    {
        [Key]
        public int id { get; set; }

        public string m_anrede { get; set; }
        public string m_vorname { get; set; }
        public string m_nachname { get; set; }
        public string m_email_adresse { get; set; }
        public string m_telefonnummer { get; set; }
        public string m_berufsbezeichnung { get; set;}

    }
}

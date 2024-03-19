using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BlazorCrudApp.Models
{
    public class Student(string name, string address, string phoneNumber, string email)
    {
        [Key]
        [DisplayName("Id")]
        public Guid Id { get; init; } = Guid.NewGuid();

        [Required(ErrorMessage = "Informe seu nome")]
        [StringLength(8, ErrorMessage = "Nome não pode possuir mais que 80 caracteres")]
        [MinLength(5, ErrorMessage = "Nome deve possuir no mínimo 5 caracteres")]
        [DisplayName("Nome")]
        public string Name { get; set; } = name;
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; } = phoneNumber;

        [StringLength(100, ErrorMessage = "Endereço não pode possuir mais que 100 caracteres")]
        [MinLength(20, ErrorMessage = "Nome deve possuir no mínimo 20 caracteres")]
        public string Address { get; set; } = address;

        [EmailAddress(ErrorMessage = "Endereço de Email Inválido.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = email;

        public bool Enable { get; set; } = true;


        public void UpdateName(string name) => Name = name;

        public void IsEnable(bool isEnable) => Enable = isEnable;
    }
}

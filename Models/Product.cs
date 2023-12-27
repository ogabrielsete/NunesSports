using System.ComponentModel.DataAnnotations;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, insira o nome do produto")]
    [RegularExpression(@"^[\p{L}\s]+$", ErrorMessage = "O nome do pagamento deve conter apenas letras.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Por favor, insira o código do produto")]
    [Range(1, 1000000, ErrorMessage = "O código deve ser maior que zero")]
    public int ProductCode { get; set; }

    [Required(ErrorMessage = "Por favor, insira a descrição do produto")]
    [StringLength(250, MinimumLength = 10, ErrorMessage = "A descrição deve conter entre 10 e 100 caracteres.")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Por favor, insira o preço do produto")]
    [DisplayFormat(DataFormatString = "{0:C}")]
    [Range(0.01, 1000000, ErrorMessage = "Valor deve ser maior que zero")]
    public decimal Price { get; set; } = default;

}

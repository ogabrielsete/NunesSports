using System.ComponentModel.DataAnnotations;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, insira o nome do produto")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Por favor, insira a descrição do produto")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Por favor, insira o preço do produto")]
    public decimal Price { get; set; }

}

using System.ComponentModel.DataAnnotations;
namespace Chat_test.Models;

public class SignInVm
{
    [Required]
    public string UserName { get; set; }
}

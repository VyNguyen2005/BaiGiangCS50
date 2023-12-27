using Microsoft.AspNetCore.Mvc.RazorPages;

/*Trong Razor Page luon co 2 file 
+ file .cshtml chu yeu dung de trinh bay
+ mode .cs mot lop ke thua tu PageModel
VD: public class FirstPageModel : PageModel
@model FirstPageModel
<1> style = "color: pink" @Model.title</h1>
<h2> @Model.Welcome("Vy") </h2>
*/

public class FirstPageModel : PageModel
{
    public string title = "DAY LA RAZOR PAGE CUA VY";
    public string title1 = "TRANG DAU TIEN NE";
    public void OnGet()
    {
        Console.WriteLine("Truy van OnGet");
        ViewData["mydata"] = "Day la ViewData OnGet";
    }
    public void OnGetAbc()
    {
        Console.WriteLine("Truy van OnGetAbc");
        ViewData["mydata"] = "Day la ViewData OnGetAbc";
    }


    public string Welcome(string name)
    {
        return $"Chao mung {name} den voi website ";
    }
}
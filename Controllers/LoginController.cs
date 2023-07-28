using Microsoft.AspNetCore.Mvc;

//this is get method which shows form fields before submitting form
public class LoginController: Controller{
    public IActionResult Index(){
        return View();
    }
//this is post method which shows Thank You as content after submitting form with correct validation
    [HttpPost]
    public IActionResult Index( LoginModel login ){
        if(ModelState.IsValid){
            return Content("Thank You!");
        }
        return View(login);
    }
    
}
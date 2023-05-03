var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //Relier les vues aux controleurs

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//Configurer les routes : le format des url
app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Welcome}/{action=WelcomeDefault}/{id?}"
);

app.MapControllerRoute(
 name: "default",
 //pattern: structure de l'url : peut contenir le contr�leur,
 //la m�thode d'action et les param�tres
 pattern: "/{nom}/{prenom}",
 //defaults : indiquer le contr�ler et la m�thode d'action par d�faut.
 defaults: new { controller = "Welcome", action = "WelcomeName" }
);


app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Route}/{action=Route1}/{id?}"
);

app.Run();

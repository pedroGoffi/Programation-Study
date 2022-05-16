# Pedro Notes About ASP net

## Flow control
STEPS:
    1. You make a REQUEST, by entering a URL in the browser;

    2. The `startup.cs` gives a default entry point in
       `endpoints.MapControllroute(name:"default", pattern: "{controller=Home}/{action=Index}/{id?}")`

       It will call Controller

    3. The Controller will choose how render the rest, if you harcode it all
       it may be a hell, its a loot of code if you have the oportunity use
       some good IDE that makes the files for you, like VSCode. 

       It will call Views

       To add your stuff here You basically just copy and paste the existent
       one and modify to do what you want to do
       i dont know how it works but ok lmao

       NOTE:    
        If you add a controll you have to add a view to render a
        specifique URL pattern

    4. The class inside `Views` with the name will be called in this case
       there's a folder called `Home` with two `.cs` files: Index.cs and
       Privacy.cs
       The URL default pattern calls Home, then Index
       if you change for Privacy instead of Index when you enter the site the
       Privacy shall be in the screen.

       Inside Views/Home/Index.cs there's a special operand: @{} that calls a
       ASP `instance`, obs: I don't know how to refer this. It will basically
       follow a configuration somewhere inside your folders to render some
       HTML, if you erase this the browsing bar will disappear.

       inside wwwroot will be your css/js/lib, source code in general



What to do know?
    Well i recommend searcg and see how use this, i mean how contrl data-base stuff and them try to walk around some 
    basic projects just to became familiar with this.

    Sice i like REACT, not because i know it but its the only stuff i know i
    will create a ASP+REACT folder. basically just run: 
    dotner new react --lang=c# -n `project name`

First thing i noticed is it uses more CPU, its about 90% of my computers
capacity kinda scary about pc stoping works ngl


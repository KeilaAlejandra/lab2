<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>REGISTRAR VIDEO</title>
    <meta charset="UTF-8">
  <meta name="description" content="ASP.NET MVC 2 CRUD Video">
  <meta name="keywords" content="ASP.NET, MVC, FACPYA">
  <meta name="author" content="KEILA CASTRO">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="../../Content/Site.css" rel="stylesheet" type="text/css" />
</head>

<body>
    <form action= "/Video/Create"method="post">
    <fieldset>
    <legend >DATOS DEL VIDEO</legend>
    <label for="idVideo">idVideo</label>
    <input type="text" name ="idVideo" />

     <label for="titulo">Titulo</label>
    <input type="text" name ="titulo" />

     <label for="reproducciones">Repro:</label>
    <input type="text" name ="reproducciones" />

     <label for="url">Url</label>
    <input type="text" name ="url" />

    <input type ="submit" name ="Registrar" /> 

    </fieldset>
    </form>
    
</body>
</html>

<html>
    <body>
        <img src="pitagoras.png" height="350" width="400" align="center">
    <?php
 
$catb = $_GET["txt_catb"];
 
$cata = $_GET["txt_cata"];
 
$hip = sqrt(pow($catb,2) + pow($cata,2));
 
echo "Valor de Hipotenusa es: " . $hip;
 
    ?>
    </body>
</html>
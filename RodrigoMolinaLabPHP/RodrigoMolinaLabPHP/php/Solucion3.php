<html>
    <body>
        <?php
            $codigo = $_GET['cod'];
            $nombre = $_GET['nombre'];
            $sueldo = $_GET['sueldo'];
            $bonif = $_GET['bonif'];
            $hextras = $_GET['hextras'];
            $desc = $_GET['desc'];
            $apellido = $_GET['apellido'];
            
            $iggs = ($sueldo * 4.83)/100;
            $hextras = ($sueldo + $bonif)/30/8 * $hextras;
            $totaling = ($sueldo + $bonif + $hextras);
            $totaldesc = ($desc + $iggs);
            $totalliq = ($totaling - $totaldesc);
        ?>
            <table border="1" align="center">
            <tr>
                <td colspan="2" align="center">DATOS GENERALES</td>
            </tr>
            <tr>
                <td align="left" width="50%">Código:  </td>
                <td align="center"><?php echo $codigo; ?></td>
            </tr>
            <tr>
                <td align="left" width="50%">Nombre Completo:  </td>
                <td align="center"><?php echo $nombre,' ', $apellido; ?></td>
            </tr>
            <tr>
                <td colspan="2" align="center">INGRESOS</td>
            </tr>
            <tr>
                <td align="left" width="50%">Sueldo Base:  </td>
                <td align="center"><?php echo $sueldo; ?></td>
            </tr>
            <tr>
                <td align="left" width="50%">Bonificacion:   </td>
                <td align="center"><?php echo $bonif; ?></td>
            </tr>
            <tr>
                <td align="left" width="50%">Horas Extras:  </td>
                <td align="center"><?php echo $hextras; ?></td>
            </tr>
            <tr>
                <td colspan="2" align="center">DESCUENTOS</td>
            </tr>
            <tr>
                <td align="left" width="50%">Descuentos:  </td>
                <td align="center"><?php echo $desc; ?></td>
            </tr>
            <tr>
                <td align="left" width="50%">IGGS:  </td>
                <td align="center"><?php echo $iggs; ?></td>
            </tr>
            <table border="1" align="center">
            <br><br>
            <tr>
                <td colspan="2" align="center">TOTAL A RECIBIR</td>
            </tr>
            <tr>
                <td align="left" width="50%">Total de Ingresos:   </td>
                <td align="center"><?php echo $totaling; ?></td>
            </tr>
            <tr>
                <td align="left" width="50%">Total de Descuentos:   </td>
                <td align="center"><?php echo $totaldesc; ?></td>
            </tr>
            <tr>
                <td align="left" width="50%">Saldo Liquido:    </td>
                <td align="center"><?php echo $totalliq; ?></td>
            </tr>
    </body>
</html>
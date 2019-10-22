<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Личный сайт студента GeekBrains</title>
	<link rel="stylesheet" href="style.css"> 
</head>
<body>

<div class="content">
<?php
	include "menu.php"
?>

	<script type="text/javascript">

var answer = parseInt(Math.random() * 100);

function readInt(){
    var number = document.getElementById("userAnswer").value;
    return parseInt(number);
    }

function write(text){
    document.getElementById("info").innerHTML = text;    
    }
    function hide(id){
        document.getElementById(id).style.display = "none";
    }    

function guess(){
    var userAnswer = prompt("Ходит игрок номер " + playerNumber + " Введите число от 0 до 100");
    var userAnswer = readInt();
        if(userAnswer == answer){
            write("<b>Поздравляю, победил игрок номер</b>" + playerNumber)
            hide("button");
            hide("userAnswer");
        }else if(userAnswer > answer){
            write("Вы ввели слишком большое число<br>Попробуйте еще раз, ходит игрок номер " + playerNumber);
        }else(userAnswer < answer){
            write("Вы ввели слишком маленькое число<br>Попробуйте еще раз, ходит игрок номер " + playerNumber);
        }
    }
    function playerNumber(){
    if(playerNumber == 1){
    playerNumber = 2;
    }
    else{
        playerNumber = 1;
    }
    }
</script>

</head>
<body>
<div class="content">



	<h1>Игра угадайка мультиплеер</h1>

	<div class="box">

	    <div class="box">
		    <form method="GET">
		    	<p> Угадайте число от 0 до 100 </p>
		    	<input type="text" name ="userAnswer">
		    	<br>
		    	<input type="submit" value="Ответить" name="">
			</form>
		   
	    </div>

</div>
<div class="footer">
	Copyright &copy; <?php echo date("Y");?> Alyona Vikhodets
<div>


</body>
</html>
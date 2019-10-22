<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Личный сайт студента GeekBrains</title>
	<link rel="stylesheet" href="style.css"> 
	<script type="text/javascript">
		function readInt(){
			var number = document.getElementById("length").value;
			return parseInt(number);
		}

		function write(text){
			document.getElementById("info").innerHTML = text;
		}
		function getRandomNumber(max){
			return Math.round(Math.random() * max);
		}
		function generate() {
			write(generateRandomString(
				 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789'.split(''), 
				 readInt()
 			));
		}
		function generateRandomString(letters, length){
			var text = "";
			for(var i = 0; i <length; i++){
				var n = getRandomNumber(letters.length - 1);
				text += letters[n];
			}

			return text;
		}
		
	</script>
</head>	
<body>

<div class="content">
	<?php include "menu.php"; ?>

	<div class="contentWrap">
    <div class="content">
        <div class="center">

			<h1>Генератор паролей</h1>

			<div class="box">

				<p>Введите желаемую длину пароля</p>
				<p id="info"></p>
				<input type="text" id="length">
				<br>
				<a href="#" onClick="generate();return false;">Генерировать</a>				
			</div>

        </div>
    </div>
</div>
</div>	
<?php include "footer.php"; ?>


</body>
</html>
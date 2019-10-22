<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Личный сайт студента GeekBrains</title>
	<link rel="stylesheet" href="style.css"> 
	<script type="text/javascript">

		var tryCount = 3;
		var playerCount = 2;
		var max = 100;
		var answer = parseInt(Math.random() * max);
		var players = [];
		var currentPlayer = 0;
		var playerTryCount = [];

		for (var i = 1; i <= playerCount; i++) {
			var name = 'Игрок '+i;
			playerTryCount.push(0);	
			players.push(name);
		}

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

		function game() {
			var player = players[currentPlayer];
			var userAnswer = readInt();
			var message = '';
			if (answer == userAnswer) {
				write('Победил '+player+'<br> Ответ '+userAnswer);
				hide('button');
				hide('userAnswer');
				return;
			}	
			else if (answer > userAnswer) {
				message = 'Загаданное число больше';
			}
			else if (answer < userAnswer) {
				message = 'Загаданное число меньше';
			}
			else {
				message = 'Вы ввели что-то странное<br> Это должно быть число<br> Но попытку свою вы потеряли';
			}

			playerTryCount[currentPlayer]++;

			if(currentPlayer == players.length - 1) {
				if (tryCount == playerTryCount[currentPlayer]) {
					write('Попытки закончились<br> Правильный ответ '+answer);
					hide('button');
					hide('userAnswer');
					return;
				}
				currentPlayer = 0;
			}
			else {
				currentPlayer++;
			}
			write(message+'<br> Теперь ходит ' + players[currentPlayer]);
		}
	</script>
</head>	
<body>

<div class="content">
	<?php include "menu.php"; ?>

	<div class="contentWrap">
    <div class="content">
        <div class="center">

			<h1>Игра угадайка</h1>

			<div class="box">

				<p id="info">Поиграйте в Угадайку с своим другом<br> У каждого из вас будет 3 попытки<br> Угадайте число от 0 до 100</p>
				<input type="text" id="userAnswer">
				<br>
				<a href="#" onClick="game();return false;" id="button">Начать</a>				
			</div>

        </div>
    </div>
</div>
</div>	
<?php include "footer.php"; ?>


</body>
</html>
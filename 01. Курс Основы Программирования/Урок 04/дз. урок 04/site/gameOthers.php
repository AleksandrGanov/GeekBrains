<!DOCTYPE html>
<html>

<head>
	<meta charset="utf-8">
	<title>Угадайка</title>
	<link rel="stylesheet" href="style.css">
	<?php include "gameNumbersFunc.php"?>
</head>

<body>

	<div class="content">
		<?php include "menu.php"; ?>

		<div class="contentWrap">
			<div class="content">
				<div class="center">
					<h1>Угадай число</h1>
					<div class="box">
						<p id="infoGame"><b>Инфо:</b> укажите кол-во игроков, ошибок и предполагаемое число,<br>после чего нажмиите "Угадать"</p>
						<p id="infoPlayers"><b>Введите количество игроков:</b> от 1 до 5</p>
						<input type="text" id="userCount">
						<p id="infoErr"><b>Введите количество попыток:</b><br>"конечное число" - укажите число от 1 до 10"<br>"бесконечные попытки" - укажите число "-1"</p>
						<input type="text" id="tryNumber">
						<p id="infoMain"><b>Введите число:</b> от 0 до 100</p>
						<input type="text" id="userAnswer">
						<br>
						<a href="#" onclick="gameStart()" id="buttonStart">Угадать</a> 
						<a href="#" onclick="gameExit()"  id="buttonExit">Выйти из игры</a>
					</div>
				</div>
			</div>
		</div>
	</div>

	<?php include "footer.php"; ?>

</body>

</html>
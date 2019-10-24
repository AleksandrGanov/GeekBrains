<!DOCTYPE html>
<html>

<head>
	<meta charset="utf-8">
	<title>Генератор пароля</title>
	<link rel="stylesheet" href="style.css">
	<?php include "passGenFunc.php"; ?>
</head>

<body>

	<div class="content">
		<?php include "menu.php"; ?>
		
		<div class="contentWrap">
			<div class="content">
				<div class="center">
					<h1>Генератор пароля</h1>
					<div class="box">
						<p id="info">Введите длину пароля от 1 до 15 символов</p>
						<input type="text" id="passLength">
						<p id="pass"><b>Ваш пароль: </b>********* </p>
						<a href="#" onclick="genPass(getInt())" id="button">Сгенерировать</a>
					</div>
				</div>
			</div>
		</div>
	</div>

	<?php include "footer.php"; ?>

</body>

</html>
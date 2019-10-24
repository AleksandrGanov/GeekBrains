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
			include "menu.php";
		?>

		<h1>Личный сайт студента GeekBrains</h1>

		<div class="center">
			<img src="images/avatar.png">
			<div class="box_text">
				<p><b>Добрый день.</b>
					<p>Меня зовут <i>Ганов Александр</i>, я совсем недавно начал программировать, однако уже написал
						свой первый сайт </p>
				</p>

				<p>В этом мне помог IT-портал <a href="https://geekbrains.ru/"><b>GeekBrains<b></a></p>


				<p>На этом сайте вы можете сыграть в игры, которые я написал и воспользоваться генератором паролей</p>
			</div>
		</div>
	</div>

	<?php include "footer.php"; ?>
	
</body>

</html>
<!DOCTYPE html>
<html>

<head>
	<meta charset="utf-8">
	<title>Игра в Загадки</title>
	<link rel="stylesheet" href="style.css">
</head>

<body>

	<div class="content">
		<?php
			include "menu.php";
		?>

		<div class="contentWrap">
			<div class="content">
				<div class="center">
					<h1>Игра в загадки</h1>
					<div class="box">
						
						<p><?php						
							if ($_GET["userAnswer01"]!="" && $_GET["userAnswer02"]!="" && $_GET["userAnswer03"]!=""){
								$userAnswer=$_GET["userAnswer01"];
								$score=0;
								if ($userAnswer=="сон"||$userAnswer=="сновидение"){
									$score++;
								}
								$userAnswer=$_GET["userAnswer02"];
								if ($userAnswer=="морской"||$userAnswer=="укус акулы"){
									$score++;
								}
								$userAnswer=$_GET["userAnswer03"];
								if ($userAnswer=="шахматный"||$userAnswer=="мертвый"){
									$score++;
								}
								echo "<b>Инфо:</b> Количество угаданных загадок ".$score."шт.";
							}
							else {echo "<b>Инфо:</b> Необходимо указать ответы на все 3 загадки";}
						?></p>

						<form method="GET">
							<p>Что можно увидеть с закрытыми глазами?</p>
							<input type="text" name="userAnswer01">

							<p>Какой болезнью никто не болеет на суше?</p>
							<input type="text" name="userAnswer02">

							<p>Какой конь не ест овса?</p>
							<input type="text" name="userAnswer03">

							<br> <input type="submit" value="Ответить" name="">
						</form>
					</div>
				</div>
			</div>
		</div>
	</div>

	<?php include "footer.php"; ?>

</body>

</html>
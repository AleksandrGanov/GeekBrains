<?php
$items = [
	[
		'question' => "Сам алый, сахарный,\nКафтан зеленый, бархатный.",
		'answers' => ["арбуз"]
	],
	[
		'question'=> "Сидит дед, в шубу одет,\nКто его раздевает, тот слезы проливает.",
		'answers' => ["лук"]
	],
	[
		'question' => "Рыжая, с пушистым хвостом\nЖивет под кустом.",
		'answers' =>  ["лиса", "лисичка"]
	],
	[
		'question' => "Под полом таится, кошки боится.",
		'answers' => ["мышь","мышка","крыса"]
	]
];  
$score = 0;
if (!empty($_GET)) {
	for ($i=0; $i < count($items); $i++) { 
		if (isset($_GET['userAnswer'.$i])) {
			$answer = mb_strtolower(trim($_GET['userAnswer'.$i]), 'UTF-8');
			if (in_array($answer, $items[$i]['answers'])) {
				$score++;
			}
		}
	}
}
?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Личный сайт студента GeekBrains</title>
	<link rel="stylesheet" href="style.css"> 
</head>
<body>

<div class="content">
	<?php include "menu.php"; ?>

<div class="contentWrap">
    <div class="content">
        <div class="center">

			<h1>Игра в загадки</h1>

			<div class="box">

				<?php if (!empty($_GET)) : ?>
					<div>Правильных ответов: <?php echo $score; ?></div>
				<?php endif; ?>

				<form>
				<?php for($i = 0; $i < count($items); $i++) : ?>
					<p><?php echo $items[$i]['question']; ?></p>
					<input value="<?php echo (isset($_GET['userAnswer'.$i]) ? $_GET['userAnswer'.$i] : '');?>" type="text" name="userAnswer<?php echo $i;?>">
				<?php endfor; ?>

				<br>
				<button type="submit">Отправить</button>
				</form>
			</div>

        </div>
    </div>
</div>

	

</div>
<?php include "footer.php"; ?>


</body>
</html>
<meta charset="utf-8">
<script type="text/javascript">

    // объявляем переменные
    var answer; //хранит сгенерированное число
    var answerString; // ответ игрока
    var checkValue; // проверка значений
    var gameOver = true; // выдавать сообщение о проигрыше, то есть когда игроки не смогли определить число
    var isInGame; //переменнаях хранить статус нахождения в игровом процессе
	var messageString; // строка сообщений в процессе игры
	var messageResult; // хранить значение результата сравнения ответа с эталоном
    var tryCount = new Array; // массив количества ошибок каждого игрока
    var tryNumber; // количество попыток каждого игрока
    var userCount; // количество игроков
    var userInGameStatus = new Array; // массив количества ошибок каждого игрока
    var userNumber = 1; // номер игрока

    // РЕАЛИЗАЦИЯ ФУНКЦИЙ
	
	function changePlayer() {
		
		// передаем ход другому игроку с учетом статуса "в игре", "не в игре"
        do {
            if ((userNumber + 1) <= userCount) {userNumber++;}
            else {userNumber = 1;}
        } while (!userInGameStatus[userNumber - 1])

        // подготавливаем строку сообщения для вывода пользователю
		if (tryNumber == -1) {messageString = messageResult + ",<br>Игрок №" + userNumber + ", попробуйте еще раз (число от 1 до 100), \n"
			+ "попытка №" + (tryCount[userNumber - 1]+1) + " (число попыток не ограничено)";}
		else {
			if (tryCount[userNumber - 1] == 0) {messageString = messageResult + ",<br>Игрок №" + userNumber + ", введите число от 1 до 100";}
			else {messageString = messageResult + ",<br>Игрок №" + userNumber + ", попробуйте еще раз (число от 1 до 100), \n"
						+ "попытка №" + (tryCount[userNumber - 1]+1) + " из " + tryNumber;
			}
		}
				
		// выводим сообщение для последующих попыток/игроков
		if (!(userNumber==1 && tryCount[userNumber-1]==0)) {writeText("infoGame", "<b>Инфо:</b> " + messageString);}		
	}
	function checkAns(value) {
		checkValue = !(isNaN(value));
        checkValue = checkValue && value > 0;
        checkValue = checkValue && value <= 100;
        return checkValue
    }
	function checkErr(value) {
        checkValue = !(isNaN(value));
        checkValue = checkValue && (value == -1 || (value >= 1 && value <= 10));
        return checkValue
    }
	function checkPlayers(value) {
        checkValue = !(isNaN(value));
        checkValue = checkValue && value >= 1;
        checkValue = checkValue && value <= 5;
        return checkValue
    }
	function fieldsLock(value) {
        if (value == 1) {
            document.getElementById("userCount").setAttribute("readOnly", true);
            document.getElementById("tryNumber").setAttribute("readOnly", true);
		}
    }
	function gameCycle() {
        if (userAnswer == answer) {
			writeText("infoGame", "<b>Инфо:</b> Вы угадали! <i>Правильный ответ:</i> " + answer);
			gameOver = false;
			return true;
         }
        else if (userAnswer > answer) {messageResult="Введено слишком <u><i>большое число</i></u>";}
        else if (userAnswer < answer) {messageResult="Введено слишком <u><i>маленькое число</i></u>";}
			
		if (tryNumber == -1 || tryCount[userNumber - 1]<tryNumber) {tryCount[userNumber - 1]++;} // записываем текущий номер попытки для текущего игрока
				
		if  (tryNumber == -1 || sumTryCounts()<tryNumber*userCount) {changePlayer();} // если у игроков еще остались попытки переключаемся на следующего игрока
		else {if (gameOver) { writeText("infoGame", "<b>Инфо:</b> Вы проиграли, число не разгадано! <u><i>Правильный ответ:</i></u> " + answer); }} // выдаем сообщение если ни один из пользователей не угадал число и хотя бы 1 остался в игре}
	}
	function gameExit() {
		if (!isInGame) { writeText("infoGame", "<b>Инфо:</b> Игра не начата, выход не возможен"); return false; }
		if (sumTryCounts()==tryNumber*userCount) { writeText("infoGame", "<b>Инфо:</b> Игра окончена для всех игроков, выход не возможен"); return false; }
		else{
			alert("Инфо: Игрок №" + userNumber + " вышел из игры"); // если игрок нажал "Отмена", то выдаем сообщение, что игрок с номером *** покинул игру
			userInGameStatus[userNumber - 1] = false; // устанавливаем стутус игрока: "в игре", "не в игре"
			//tryCount[userNumber - 1] = tryNumber; // устанавливаем стутус игрока: "в игре", "не в игре"
            var i = 0; // обнуляем счетчиков оставшихся в игре игроков
            userInGameStatus.forEach(function (item) {if (item) { i++; }});  // путем перебора определяем сколько игроков осталось в игре
            if (i == 0) {  // проверяем если все игроки вышли, то заканчиваем игру
				writeText("infoGame", "<b>Инфо:</b> Игра завершена, все игроки покинули игру");
                gameOver = false;
                return true;
			} 
			else {changePlayer();}
		}
    }
	function gameStart() {
		
		// проверяем заполнены ли массивы количества ошибок и игроков в игре
		// если не заполнены, то запрашиваем значения, если заполнены, то значит значения пользователь уже ввел
		if (tryCount.length==0&&userInGameStatus.length==0) {
			if (!checkPlayers(+readText("userCount"))) { // проверяем корректность ввода количества игроков
				writeText("infoGame", "<b>Инфо:</b> Необходимо указать хотя бы одного игрока (макcимум 5 чел)");
				return false;
			}
			else { userCount = +readText("userCount"); }
			
			if (!checkErr(+readText("tryNumber"))) { // проверяем корректность ввода количества ошибок
				writeText("infoGame", "<b>Инфо:</b> Необходимо указать количество попыток (максимум 10шт)");
				return false;
			}
			else { tryNumber = +readText("tryNumber"); }
			
			gameStats(); // заполняем начальные значения для массива игровой статистики
			fieldsLock(1); // блокируем поля до окончания игрового процесса
			isInGame=true;
		}
  
		if (!checkAns(+readText("userAnswer"))) { // проверяем корректность ввода ответа пользователя
			writeText("infoGame", "<b>Инфо:</b> Необходимо ввести значение от 1 до 100");
			return false;
        }
        else { userAnswer = readText("userAnswer"); }
        gameCycle(); //запускаем игровой цикл
	}
    function gameStats() {
        // заполняем массив количества ошибок, массив статусов
        for (var i = 0; i < userCount; i++) {
            tryCount[i] = 0;
            userInGameStatus[i] = true;
        }
	}	
	function hideElement(id) {
		document.getElementById(id).style.display = "none";
	}	 
	function writeText(id, text) {
            document.getElementById(id).innerHTML = text;
    }
	function readText(id) {
            return document.getElementById(id).value;
	}
	function sumTryCounts(){
		var sum=0; //общее число попыток на всех игроков
		tryCount.forEach(function (item) { sum += item; })
		return sum
	}
	
	// ОСНОВНОЙ КОД
	answer = parseInt(Math.random() * 100); // генерируем случайное число

</script>
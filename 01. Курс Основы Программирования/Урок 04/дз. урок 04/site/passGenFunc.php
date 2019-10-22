<meta charset="utf-8">
<script type="text/javascript">
    
    function getInt() {
        var checkValue=false;
        var value = +document.getElementById("passLength").value;
        checkValue = !(isNaN(value));
		checkValue = checkValue && value >= 1;
		checkValue = checkValue && value <= 15;
        if(checkValue) {
            return value;}
        else {
            writeText("info","<b>Введите число от 1 до 15!!!</b>");
            return 0;
        }
    }
    function genPass(pass) {
        if (pass!=0){
            var arrPass = "";
            for (i = 1; i <= pass; i++) {arrPass += passSymbols();}
            writeText("pass","<b>Ваш пароль:</b> " + arrPass);
            writeText("info","Введите длину пароля от 1 до 15 символов");
        }
    }
    function genRndNumber(long) {
        return Math.round(Math.random() * long);
    }
    function passSymbols() {
        var numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0];
        var letters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
        var rnd = genRndNumber(2);
        switch (rnd) {
            case 0:
                return numbers[genRndNumber(numbers.length - 1)];
            case 1:
                return letters[genRndNumber(letters.length - 1)];
            case 2:
                return letters[genRndNumber(letters.length - 1)].toUpperCase();
        }
    }
    function writeText(id,text) {
		document.getElementById(id).innerHTML = text;
    }

</script>
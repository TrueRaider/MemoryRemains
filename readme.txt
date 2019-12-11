1. Установите Rider;

2. Разместите файл jetbrains-agent.jar в любой удобной папке;

3. Перейдите к настройке окружения IDE: лаунчер -> "Configure" -> "Edit Custom VM Options..." либо IDE -> "Help" ->  "Edit Custom VM Options...", согласитесь на создание файла;

4. В конец открывшегося конфигурационного файла добавьте строку "-javaagent:/абсолютный/путь/к/файлу/jetbrains-agent.jar" (без кавычек);

5. Перезапустите dfgd;

6. Перейдите к настройке лицензии: лаунчер -> "Configure" -> "Manage License..." либо IDE -> "Help" ->  "Register...";

7. -> "License server", введите в поле адреса "http://jetbrains-license-server" (без кавычек), -> "Activate". Готово.ddfd
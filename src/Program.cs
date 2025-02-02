﻿Screen screen = new Screen();
Menu menu = new Menu(screen);
AppointmentController appointmentController = new AppointmentController(screen);

// Constrói uma janela que preenche o espaço inteiro disponível.
screen.buildFrame(0, 0, screen.WindowWidth, screen.WindowHeight);

menu.add("Bater Ponto [C]");
menu.add("Consultar Ponto [R]");
menu.add("Sugerir Alteração [U]");
menu.add("Remover Horário Registrado [D]");
menu.add("Ajuda [H]");
menu.add("Sair [Q]");
menu.show();


while (true) {
  string answer = menu.choose();

  if (answer == "") {
    answer = "Q";
  }
  answer = answer.ToUpper();

  if (answer == "C") {
    appointmentController.add();
  }
  else if (answer == "R") {
    appointmentController.list();
  }
  else if (answer == "U") {
    appointmentController.update();
  }
  else if (answer == "D") {
    appointmentController.update(true);
  }
  else if (answer == "H") {
    Help help = new Help(screen);

    screen.clearFrame(screen.InitialColumn, 0, screen.WindowWidth, screen.WindowHeight);
    help.list();
  }
  else if (answer == "Q") {
    break;
  }
}

Console.Clear();

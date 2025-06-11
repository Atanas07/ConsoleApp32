//1 delegate-a e tip koito ima signature kum metoda si ,mojem da go narechem ukazatel ili poiter na funkciq
//2 abonirame s += i s -= otabonirame
//3 pri izvikvaneto metodite koito sme dobavili se izppulnqvat edin po edin v reda na tqhnoto dobavqne i se vrushta suotvetno dadenata stoinost na metoda ako ima takava
//4 eventa e nqkakvo subitieto koeto signalizira che neshto se e sluchilo ili se e izpulnilo dadeno neshto

using ConsoleApp31;

Hero hero1 = new Hero("Darius ", 25, 6);
Hero hero2 = new Hero("Garen ", 75, 2);
BattleManager battleManager = new BattleManager(hero1, hero2);
battleManager.StartBattle();


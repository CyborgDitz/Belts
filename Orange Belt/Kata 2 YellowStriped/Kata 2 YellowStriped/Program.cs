using ConsoleApp1;

Character goblino = new Character("Goblino", 55, 50); //OCP 
Character player = new Character("Player", 111, 5);
goblino.HealthChanged += goblino.OnHealthChanged;
player.HealthChanged += player.OnHealthChanged; //DRy fix


player.Attack(goblino); //KISS (Keep it simple, stupid) //Separation of Concerns
goblino.Attack(player);

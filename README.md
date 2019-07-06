# Battle Tank Game

**Battle Tank** is an open-source 2 player game. The main idea of the project/game was to develop something using *Windows Forms Application* and to make the game fun to play, so the users will be happy and entertained with some interesting user interfaces.
## Development
*Battle Tank* is developed by 4 computer science students. It is 
completed on 05.07.2019 and ready to play. 

**Loading scene** is a scene that warns the player before entering the main screen.
After filling the loadig panel, begins the second scene which is the main scene
![LoadingScene](https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/LoadingScene.png)
## Gameplay
Initially, the application starts with a form in which the user will be able to log in, play, see the best players of the game and also the manual in which the users will be shown a screen on how to play the game (which buttons to press).

The game begins with the users logging to their respective accounts.  Before they log in they have to be registered. The feature to log in the users will make the game more interesting since their points will be saved in a database.<br/>In case the players/users want their point to be saved for later plays, 
both of the players need to log in, so the game can be played. The game can also be played without the need to register, but the points won't be saved.

Battle starts immediately when the game launches. Initially, two players are given a random position in the map, which is generated randomly from the pool of maps, and after that the players are positioned on random positions also. The map consists of some barriers in which the rockets that come out of the tank can not pass. Instead, they will bounce back and after some seconds they will disappear. Also, the tank is not allowed to go through the barriers, instead it needs to go back, since the wall will block it from moving.

One thing that makes the game more interesting is that the tank can be destroyed by his own rocket. The players need to be careful not to shoot as much as they want, since they can get destroyed by their own rockets.

### Tank Features

One another important feature or something that is characteristic for this tank its that it can rotate in 360 degrees, to the left and right. Tank also moves forward and backward.
Its important to mention that turret also enables us to run the tank by moving it forward  and backward.

The barrel that sticks out from the turret is the tank’s gun and serves as its primary weapon during the game from where the tank fires bullets.
Turret also show us the bullets direction during a specific moment by firing bullets in certain area, which means bullets have the same direction turret has.
If the bullets face a barrier or another obstacle that prevents their movement or access, bullets can change the direction and return to the opposite side.

When the tank is hit by the bullet, the tank is destroyed as shown in the next photo:
![BurnedTank](https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/BurnedTank.png)

At the moment when the tank breakdown occurs, in the relevant fields for the presentation of the tank (name and points) automatically generates a point for the winning tank, and then the game continues to the next level.




The main idea of the **`btnRegister_Click`** function is to search through the database and see if there is a user with the same name as the one the user just set on the log-in form. If there is any, the message will be shown that the user with that name already exists, so the user will have to enter a different username. If not, new entry will be added into the database with their respective credentials and with 0 points initially. 

The **`btnLogin_Click`** is more complicated. Here, we look through the database and we make sure that the user with those credentials he just entered exists on the database so he will be logged in successfully. The game won't be accessible to play if there are not two users that are logged in. After two successfully logins, the game is ready to play with pressing the `ENTER` or `SPACE` button. With pressing one of these, the game will start with those two respective players.

**vazhdo ktu kujt I perket .. mvarsisht pi rrjedhjes lojes** 

In this function I get the two users and their respective points as arguments, and after that I had to search the database to find those two players and their points. After the game is finished, I update their points by adding the existing points and the new points they just earned while playing. Before that, I make sure that the game is played only with registered users. 
they are not, I just **`return`** and don't open the database for further changes.

### Results Scene
In the end, after the game is over, we can see the results scene as follows:
If the winning player is green tank it has been emphasized as in the photo:

![GreenTank](https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/GreenTankWinner.png)

The same applies to the case when the winner player is brown tank
![BrownTank](https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/BrownTankWinner.png)


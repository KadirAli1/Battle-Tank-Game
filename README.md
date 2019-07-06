# Battle Tank Game

**Battle Tank** is an open-source 2 player game. The main idea of the project/game was to develop something using *Windows Forms Application* and to make the game fun to play, so the users will be happy and entertained with some interesting user interfaces.
## Development
*Battle Tank* is developed by 4 computer science students. It is 
completed on 05.07.2019 and ready to play. 

**Loading scene** is a scene that warns the player before entering the main screen.
After filling the loadig panel, begins the second scene which is the main scene
![LoadingScene](https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/LoadingScene.png)

**Main scene** is a scene which shows all the possible buttons to start the game, such as Play, Keys, Login, Scores, sound off and sound on.
![MainScene](https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/MainScene.png)

**Keys scene** is a scene that tells us with what signs the game can play, for player 1 and player 2.
![KeysScene](https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/KeysScene.png)
## Gameplay
Initially, the application starts with a form in which the user will be able to log in, play, see the best players of the game and also the manual in which the users will be shown a screen on how to play the game (which buttons to press).

The game begins with the users logging to their respective accounts.  Before they log in they have to be registered. The feature to log in the users will make the game more interesting since their points will be saved in a database.<br/>In case the players/users want their point to be saved for later plays, 
both of the players need to log in, so the game can be played. The game can also be played without the need to register, but the points won't be saved.

Battle starts immediately when the game launches. Initially, two players are given a random position in the map, which is generated randomly from the pool of maps, and after that the players are positioned on random positions also. The map consists of some barriers in which the rockets that come out of the tank can not pass. Instead, they will bounce back and after some seconds they will disappear. Also, the tank is not allowed to go through the barriers, instead it needs to go back, since the wall will block it from moving.

One thing that makes the game more interesting is that the tank can be destroyed by his own rocket. The players need to be careful not to shoot as much as they want, since they can get destroyed by their own rockets.


The main idea of the **`btnRegister_Click`** function is to search through the database and see if there is a user with the same name as the one the user just set on the log-in form. If there is any, the message will be shown that the user with that name already exists, so the user will have to enter a different username. If not, new entry will be added into the database with their respective credentials and with 0 points initially. 

The **`btnLogin_Click`** is more complicated. Here, we look through the database and we make sure that the user with those credentials he just entered exists on the database so he will be logged in successfully. The game won't be accessible to play if there are not two users that are logged in. After two successfully logins, the game is ready to play with pressing the `ENTER` or `SPACE` button. With pressing one of these, the game will start with those two respective players.

**vazhdo ktu kujt I perket .. mvarsisht pi rrjedhjes lojes** 

In this function I get the two users and their respective points as arguments, and after that I had to search the database to find those two players and their points. After the game is finished, I update their points by adding the existing points and the new points they just earned while playing. Before that, I make sure that the game is played only with registered users. 
they are not, I just **`return`** and don't open the database for further changes.

## Tank Features

One another important feature or something that is characteristic for this tank its that it can rotate in 360 degrees, to the left and right. Tank also moves forward and backward.
Its important to mention that turret also enables us to run the tank by moving it forward  and backward.

The barrel that sticks out from the turret is the tank’s gun and serves as its primary weapon during the game from where the tank fires bullets.
Turret also show us the bullets direction during a specific moment by firing bullets in certain area, which means bullets have the same direction turret has.
If the bullets face a barrier or another obstacle that prevents their movement or access, bullets can change the direction and return to the opposite side.

When the tank is hit by the bullet, the tank is destroyed as shown in the next photo:
![BurnedTank](https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/BurnedTank.png)

At the moment when the tank breakdown occurs, in the relevant fields for the presentation of the tank (name and points) automatically generates a point for the winning tank, and then the game continues to the next level.


### Results Scene
In the end, after the game is over, we can see the results scene as follows:
If the winning player is green tank it has been emphasized as in the photo:

![GreenTank](https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/GreenTankWinner.png)

The same applies to the case when the winner player is brown tank
![BrownTank](https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/BrownTankWinner.png)


# IMPLEMENTATION

Now we are going to present some of project's code snippets in order to convey our approach that we used in order to make our idea a reality.
# Wall
This is the class whose job is to implement the Walls (obstacles) of the scenes.
```csharp
class Wall{
    // Rectangle is the "place" where the image is drawn and is later useful for checking collisions 
    // of the objects inside the scene with the walls
    Rectangle Rectangle;                        
    Image Iamge;
    ...
    public void Draw(Pen pen, Graphics g)
    {
        g.DrawRectangle(pen, Rectangle); // Rectangle's color is the same as the background so it is unseed
        g.DawImage(Image, Rectangle);
    }
}
```

# Scene

This is the super class of project's scenes.
```csharp 
class Scene{
    /* Every Scene is implemented by drawing a number of wall images with the specified size
       So we have to know the number of such images that are needed to form a row and a column */
    int NumberOfWallImagesInRow;
    int NumberOfWallImagesInColumn;
    Color BackgroundColor;
    
    /* Why are defined two distinct Lists?
       Because We don't need to check collision of objects that move inside the scene (Bullets, Tanks) 
       with the DecorWalls because they are outside */
    List<Wall> InnerWalls;
    List<Wall> DecorWalls;
    
    // Due to the scenes are generated dynamically, we had to define some Controls and insert them 
    // in the specified positions
    PictureBox PictureBoxPlayer1;
    PictureBox PictureBoxPlayer2;
    Label LabelPlayer1Name;
    Label LabelPlayer2Name;
    Label LabelPlayer1Result;
    Label LabelPlayer2Result;
    
    ...
    // Function that draws the Walls
    public void Draw(Pen pen, Graphics g)
    {
        ...
        foreach(Wall innerWall in InnerWalls)
        {
            innerWall.Draw(pen,g);
        }
        foreach(Wall decorWall in DecorWalls)
        {
            decorWall.Draw(pen,g);
        }
    }
    
    public void DrawOtherElements(SceneForm sceneForm)
    {
        // This is a function where we draw other elements outside the scene like the 
        // result panels for every player
        ...
    }
    
} 
```

Then, we have defined 10 classes with the name SceneN, where N is a number from 1 to 10, that are derived from Scene class.

```csharp
class SceneN : Scene
{
   /* This is a class whose constructor is filled with adding Walls to List<Wall> in the exact location 
      for every scene
      Every Scene has different:
        - locations of Walls - and this is determined by first parameter of new Wall(...) and 
        - appearance of Walls - and this is determined by second parameter of new Wall(...) 
   */
   public SceneN(int Width, int Height) : base(...)
   {
        
        Walls.Add(new Wall(new Rectangle(....), Resources.WallImage)
        ...
   }
}
```

Now, we are going to present some screenshots of generated scenes from these classes:


<img src="https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/Scenes/Scene8.png" alt="scene8" width="400" height="400"/>   <img src="https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/Scenes/Scene3.png" alt="scene3" width="400" height="400"/>
<img src="https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/Scenes/Scene4.png" alt="scene4" width="400" height="400"/>   <img src="https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/Scenes/Scene7.png" alt="scene7" width="400" height="400"/>
<img src="https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/Scenes/Scene9.png" alt="scene4" width="1000" height="400"/>
<img src="https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/Scenes/Scene1.png" alt="scene4" width="1000" height="600"/>

All of the scenes appearance can be found [here](https://github.com/KadirAli1/Battle-Tank-Game/tree/master/Screenshots/Scenes).

# Tank
This is the class where all the properties and functionalities of the Tank are defined.

```csharp
class Tank{
    float X;                // X-coordinate of the Tank's location
    float Y;                // Y-coordinate of the Tank's location
    float Angle;            // Direction (angle in radians) of the Tank
    float Dx;               // X-coordinate relocation for every movement (depending on the Angle of Direction)
    float Dy;               // Y-coordinate relocation for every movement (depending on the Angle of Direction)
    int MovingSpeed;
    int RotatingSpeed;
    Image Image;            // Appearance of the Tank
    Rectangle TankRectangle;// Tank image placeholder and used for checking collisions
    bool IsTankBurned;      // If Tank is burned, suitable Image shows up
    
    ...
    
    // To calculate the relocation parameters of Tank after every rotation (changing angle, direction)
    private void calculateDxDy(){
        Dx = Math.Cos(Angle) * SpeedMoving;
        Dy = Math.Sin(Angle) * SpeedMoving;
    }
    
    public void Draw(Graphics g)
    {
            ...
            // Here is used Matrix in order to ROTATE the IMAGE of the TANK according to the 
            // value of Angle property
            using (Matrix m = new Matrix())
            {
                m.RotateAt(Angle, new PointF(X + (TankDimensions.Width / 2), Y + (TankDimensions.Height / 2)));
                g.Transform = m;
                g.DrawImage(Image, X, Y, TankDimensions.Width, TankDimensions.Height);
                g.ResetTransform();
            }
            ...
    }
    
    public void Move(bool forward, bool backward, bool leftRotate, bool rightRotate, List<Wall> Walls)
    {
        // Here we use some bool variables and according to them we make the relocation (movement) of the tank
        ...
    }
    
    public void IsCollidingWithWalls()
    {
        // Here is implemented checking the Tank if it hits the Walls
        ...
    }
    
    public Bullet Fire()
    {
        // This is a function that implements Tank's Firing
        // The bullet start moving from the center of the Tank Rectangle and continues moing in the 
        // Tank's direction
        ...
    }
    
    public void IsCollidingWithBullet()
    {
        // This is a function that checks if the Tank collides with any existing Bullets in the Scene
        // If that happens, then the Tank gets burned and the player collided with the Bullet loses the round
        ...
    }
}
```
Tank's appearance and movement shown below:

<img src="https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/gifs/tank_movement.gif" alt="tank_movement"/>

# Bullet
This is the class where all the properties and functionalities of the Bullet (after the Tank fires) are implemented.

```csharp
class Bullet
{
    ...
    
    ...
    
    
    public void Move(Scene scene)
    {
        // We take scene as a parameter because every scene has its walls
        ...
    }
    
    public void IsCollidingithWalls(Scene scene)
    {
        ...
    }
}
```
Bullet's functionalities are shown below:

<img src="https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/gifs/tank_bullets.gif" alt="tank_bullets"/>

# Player

This class has been defined in order to represent a player.

```csharp
class Player
{
    string Name; 
    int Points;             // Here is stored the result of the player in order to update
                            // the result of the player in every round during the game
    Tank Tank;              // Which Tank is using (Brown or Green Tank)
    bool IsPlayerBurned;
    ...
    
    public void Draw(Graphics g)
    {
        Tank.Draw(g);
        IsPlayerBurned = Tank.IsTankBurned;
    }
}
```

# NewGame

NewGame class is defined in order to have control over the game starting and flowing.

```csharp
class NewGame
{
    Scene scene;
    Player Player1;
    Player Player2;
    ...
    
    public void GenerateScene()
    {
        // The Game is played in 11 rounds
        // The first scene is generated randomly
        // Other scenes are generated in row
        // For one game there will be shown all the defined scenes (only one scene twice)
        // Because there are a total number of scenes: 10
        ...
    }
    
    public void DrawScene(Pen pen, Graphics g, SceneForm sceneForm)
    {
         Scene.Draw(Pen, g);
         Scene.DrawOtherElements(sceneForm);
         Player1.Draw(g);
         Player2.Draw(g);
    }
}

```

# Demonstration of Playing the Game with 11 Rounds

* **Here are shown the first 45s of the game:**

<img src="https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/gifs/final_first.gif" alt="final_first"/>


* **Here are shown the last 40s:**

<img src="https://github.com/KadirAli1/Battle-Tank-Game/blob/master/Screenshots/gifs/final_second.gif" alt="final_second"/>

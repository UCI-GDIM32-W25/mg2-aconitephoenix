[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
In the plan that I drew, I outlined the attributes of each GameObject I planned to put in my game. There are some differences in the plan vs. the actual product, however, as I realized that my plan needed some adjusting when it finally came down to implementing the code. 

Like the plan, my Player has a SpriteRenderer, CapsuleCollider2D, Rigidbody2D, and a Transform. My Coin prefab also has a SpriteRenderer, a Collider, and a Transform. During coding, I updated my GameController to include the Coin prefab and the points number text, as well as a timer for the interval between coin spawns. 

Knowing that the player had to jump properly (not being able to double jump), I implemented a few if statements in the Update method of the Player class. If the input for the space key getting pressed was received and _isGrounded (a member variable of the Player class to check if the player is on the ground) is true, then the player is allowed to jump and _isGrounded is set to false while the player is in the air. The OnCollisionEnter2D method in the Player class checks for if the player has collided with the ground by checking the tag of the collided object, marking _isGrounded as true if the tag is "Ground". OnTriggerEnter2D specifically checks for if the coins have been collided with since the coins are the only object in the game to have IsTrigger checked in order to allow the player to pass through them. Once the collision has occurred, the method destroys the coin object and updates the points (both value and text). 

The coin prefab uses its transform to translate the coin across the screen towards the left as the game runs.

The GameController is used to spawn the coins at random intervals using Random.Range(). The Update method is used to subtract Time.deltaTime from the timer every frame until it hits 0, to which it'll then spawn a coin and randomize the timer again. The GameController class also has a method called UpdatePoints that updates the points text based on the number of points passed through its parameter. 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
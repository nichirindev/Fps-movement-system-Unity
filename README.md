# Fps-movement-system-Unity
which is kinda cool<br>
This can be used for various games<br>
if you don't want the wallrunning and jumping just comment them out and remove the controls from myInput or reduce the sliding force<br>
<br>

<img width="400" height="250" alt="Screen Recording 2026-06-23 014932 (1)" src="https://github.com/user-attachments/assets/c0a2050e-8e75-4ea7-8e93-6e126edb7f44" /><br>
<br>
Seamless WASD Movement<br>
WallRun with camera effects<br>
WallJump<br>
Jump<br>
Crouch<br>
Head-Bob & Sway<br>
Sliding<br>
Smooth Camera ( thx to interpolate )<br>
Subtle Landing camera effect<br>
<br>
# Setup
## Map and Ground
Create a Unity 3D project import your textures and all<br>
Create a Folder and import the scripts<br>
<br>
<img width="258" height="189" alt="image" src="https://github.com/user-attachments/assets/2d39941d-6e86-480b-847d-f03aef73d449" /><br>
<br>
Make a simple map where you have a floor and some walls which are 90 degree on z-axis (local-axis) for wallrun<br>
<br>
<img width="1483" height="982" alt="image" src="https://github.com/user-attachments/assets/c20826e0-a31c-4d92-b89e-ecb4375ce858" /><br>
<br>
**** Wallrun will only happen to the walls which are at 90 or straight or upright<br>
<br>
Create a Layer named Ground & Set the layer of everything your player should be able to walk on to Ground<br>
<br>
<img width="782" height="431" alt="image" src="https://github.com/user-attachments/assets/e1648515-922d-4eeb-a094-2d69b4d5e94a" /><br>
<img width="770" height="390" alt="image" src="https://github.com/user-attachments/assets/778d5121-4725-44c3-bff8-45b61e30d1e5" /><br>
<img width="786" height="370" alt="image" src="https://github.com/user-attachments/assets/129aadbd-94b9-4e78-a1fb-2712fedf393c" /><br>
<br>

## Player<br>

Create a Capsule<br>
Hierarchy --> 3D Objects --> Capsule<br>
<br>
<img width="627" height="145" alt="image" src="https://github.com/user-attachments/assets/e5e70c5d-84fb-4202-81eb-a375371c3e4a" /><br>
<br>
Name it Player<br>
Increase it's 'Y' in scale to 1.5 (preference)<br>
<br>
<img width="772" height="216" alt="image" src="https://github.com/user-attachments/assets/3a95e283-faf8-4410-bf19-95a6a8412ed2" /><br>
<br>
Attach Rigidbody component & PlayerMovement script to the Player<br>
Keep it Interpolate and increase it's mass up a bit<br>
Freeze it's rotation<br>
<br>
<img width="483" height="703" alt="image" src="https://github.com/user-attachments/assets/b8ea84a4-6af3-4b0e-b3fb-c5e6e29925a3" /><br>
<br>
Create two empty GameObjects under Player<br>
1. Head
2. Orientation<br>
<br>
<img width="240" height="77" alt="image" src="https://github.com/user-attachments/assets/15c34f1b-f9ce-4f7e-b8a0-01e27efe0e39" /><br>
<br>
<img width="782" height="259" alt="image" src="https://github.com/user-attachments/assets/2d8b0e4a-5b87-489f-a442-26593eb35c13" /><br>
<img width="788" height="257" alt="image" src="https://github.com/user-attachments/assets/490f3241-f03a-44b9-8552-c5fbfeed2338" />br<>
<br>

## Camera

Create a empty GameObject and name it Camera attach the MoveCamera Script here<br>
<br>
<img width="786" height="639" alt="image" src="https://github.com/user-attachments/assets/3d20932c-57a7-4bd0-a078-9a8e4c360330" /><br>
<br>
Place your MainCamera under it<br>
<br>
<img width="253" height="49" alt="image" src="https://github.com/user-attachments/assets/b8977d36-2486-4095-8966-897783216666" /><br>
<br>

## Physics Materials

Create a Physics Material named Player in your Assets<br>
<br>
<img width="438" height="777" alt="image" src="https://github.com/user-attachments/assets/17f190b6-8ee6-41d0-bd54-523e7f60d7ad" /><br>
<br>
Set Dynamic & Static Friction to 0 ( both )<br>
Set Friction Combine to minimum<br>
<br>
<img width="788" height="286" alt="image" src="https://github.com/user-attachments/assets/e96c8118-6dc4-45e3-a434-b819e0302655" /><br>
<br>

## Assignables

1. The Camera here is the top/above/parent one ( empty game object wiht the script )<br>
2. The Orientation is the child of Player ( the empty game object named  Orientation )<br>
3. The Rb is of Player ( drag the rigidbody or the Player into the slot )<br>
4. Select Ground from the Dropdown for what is ground<br>
5. Select what you consider is a wall from the dropdown for What is Wallrunnable ( you can have a different layermask/layer for the wall )<br>
<br>
<img width="776" height="330" alt="image" src="https://github.com/user-attachments/assets/ee2811fc-8c02-4383-bfcb-29116f426d9a" /><br>
<br>
----------------------------------------<br>
<br>
The Head is a child of Player ( the empty GameObject )<br>
<br>
<img width="780" height="360" alt="image" src="https://github.com/user-attachments/assets/eda3e883-ed3d-41c6-a7ef-3673acbdb5a3" /><br>
<br>

## Project Settings

Open The Project Settings<br>
<br>
Edit --> Project Settings<br>
<br>
<img width="539" height="1099" alt="image" src="https://github.com/user-attachments/assets/55bfd8e4-90c2-4587-b70c-3eaef11f998f" /><br>
<img width="1644" height="437" alt="image" src="https://github.com/user-attachments/assets/26da4a7d-cd9d-4e6d-bd11-9957d6809b05" /><br>
<br>
Head to Physics section<br>
Decrease the Y-value to -30, it increases the amount of gravity in project<br>

## There you go! All Set :3

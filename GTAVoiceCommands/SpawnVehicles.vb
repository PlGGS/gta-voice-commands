Imports GTA
Imports Microsoft.Speech
Imports GTA.Native
Imports System.Drawing
Imports GTAVoiceCommands.Main

Public Class SpawnVehicles
    Inherits Script

    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine

    Dim byteVehicleNum As Short = -1

    Friend Shared colVehiclePrimaryColor As Color = Color.White
    Friend Shared colVehicleSecondaryColor As Color = Color.White

    Friend Shared boolShowVehiclePrimaryColor As Boolean = False
    Friend Shared boolShowVehicleSecondaryColor As Boolean = False

    Friend Shared intVehiclePrimaryColorType As SByte = 0
    Friend Shared intVehicleSecondaryColorType As SByte = 0

    'ColorTypes:
    '0 = White
    '1 = Black
    '2 = Red
    '3 = Orange
    '4 = Yellow
    '5 = Green
    '6 = Blue
    '7 = Purple
    '8 = Pink

    'Load
    Public Sub New()

        Interval = 1

        reco = Main.reco

    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

        If boolBVCEnabled = True Then

            Select Case e.Result.Text

                Case strKeyWord & ", spawn vehicle Adder"

                    byteVehicleNum = 0

                Case strKeyWord & ", spawn vehicle Airbus"

                    byteVehicleNum = 1

                Case strKeyWord & ", spawn vehicle Airtug"

                    byteVehicleNum = 2

                Case strKeyWord & ", spawn vehicle Akuma"

                    byteVehicleNum = 3

                Case strKeyWord & ", spawn vehicle Alpha"

                    byteVehicleNum = 4

                Case strKeyWord & ", spawn vehicle Ambulance"

                    byteVehicleNum = 5

                Case strKeyWord & ", spawn vehicle Annihilator"

                    byteVehicleNum = 6

                Case strKeyWord & ", spawn vehicle Army Tanker"

                    byteVehicleNum = 7

                Case strKeyWord & ", spawn vehicle Army Trailer"

                    byteVehicleNum = 8

                Case strKeyWord & ", spawn vehicle Army Trailer 2"

                    byteVehicleNum = 9

                Case strKeyWord & ", spawn vehicle Asea"

                    byteVehicleNum = 10

                Case strKeyWord & ", spawn vehicle Asea 2"

                    byteVehicleNum = 11

                Case strKeyWord & ", spawn vehicle Asterope"

                    byteVehicleNum = 12

                Case strKeyWord & ", spawn vehicle Bagger"

                    byteVehicleNum = 13

                Case strKeyWord & ", spawn vehicle Bale Trailer"

                    byteVehicleNum = 14

                Case strKeyWord & ", spawn vehicle Baller"

                    byteVehicleNum = 15

                Case strKeyWord & ", spawn vehicle Baller 2"

                    byteVehicleNum = 16

                Case strKeyWord & ", spawn vehicle Banshee"

                    byteVehicleNum = 17

                Case strKeyWord & ", spawn vehicle Barracks"

                    byteVehicleNum = 18

                Case strKeyWord & ", spawn vehicle Barracks 2"

                    byteVehicleNum = 19

                Case strKeyWord & ", spawn vehicle Barracks 3"

                    byteVehicleNum = 20

                Case strKeyWord & ", spawn vehicle Bati"

                    byteVehicleNum = 21

                Case strKeyWord & ", spawn vehicle Bati 2"

                    byteVehicleNum = 22

                Case strKeyWord & ", spawn vehicle Benson"

                    byteVehicleNum = 23

                Case strKeyWord & ", spawn vehicle Besra"

                    byteVehicleNum = 24

                Case strKeyWord & ", spawn vehicle Bf Injection"

                    byteVehicleNum = 25

                Case strKeyWord & ", spawn vehicle Biff"

                    byteVehicleNum = 26

                Case strKeyWord & ", spawn vehicle Bifta"

                    byteVehicleNum = 27

                Case strKeyWord & ", spawn vehicle Bison"

                    byteVehicleNum = 28

                Case strKeyWord & ", spawn vehicle Bison 2"

                    byteVehicleNum = 29

                Case strKeyWord & ", spawn vehicle Bison 3"

                    byteVehicleNum = 30

                Case strKeyWord & ", spawn vehicle BJXL"

                    byteVehicleNum = 31

                Case strKeyWord & ", spawn vehicle Blade"

                    byteVehicleNum = 32

                Case strKeyWord & ", spawn vehicle Blazer"

                    byteVehicleNum = 33

                Case strKeyWord & ", spawn vehicle Blazer 2"

                    byteVehicleNum = 34

                Case strKeyWord & ", spawn vehicle Blazer 3"

                    byteVehicleNum = 35

                Case strKeyWord & ", spawn vehicle Blimp"

                    byteVehicleNum = 36

                Case strKeyWord & ", spawn vehicle Blimp 2"

                    byteVehicleNum = 37

                Case strKeyWord & ", spawn vehicle Blista"

                    byteVehicleNum = 38

                Case strKeyWord & ", spawn vehicle Blista 2"

                    byteVehicleNum = 39

                Case strKeyWord & ", spawn vehicle Blista 3"

                    byteVehicleNum = 40

                Case strKeyWord & ", spawn vehicle Bmx"

                    byteVehicleNum = 41

                Case strKeyWord & ", spawn vehicle Boat Trailer"

                    byteVehicleNum = 42

                Case strKeyWord & ", spawn vehicle Bobcat XL"

                    byteVehicleNum = 43

                Case strKeyWord & ", spawn vehicle Bodhi"

                    byteVehicleNum = 44

                Case strKeyWord & ", spawn vehicle Boxville"

                    byteVehicleNum = 45

                Case strKeyWord & ", spawn vehicle Boxville 2"

                    byteVehicleNum = 46

                Case strKeyWord & ", spawn vehicle Boxville 3"

                    byteVehicleNum = 47

                Case strKeyWord & ", spawn vehicle Boxville 4"

                    byteVehicleNum = 48

                Case strKeyWord & ", spawn vehicle Brawler"

                    byteVehicleNum = 49

                Case strKeyWord & ", spawn vehicle B Type"

                    byteVehicleNum = 50

                Case strKeyWord & ", spawn vehicle Buccaneer"

                    byteVehicleNum = 51

                Case strKeyWord & ", spawn vehicle Buffolo"

                    byteVehicleNum = 52

                Case strKeyWord & ", spawn vehicle Buffolo 2"

                    byteVehicleNum = 53

                Case strKeyWord & ", spawn vehicle Buffolo 3"

                    byteVehicleNum = 54

                Case strKeyWord & ", spawn vehicle Bulldozer"

                    byteVehicleNum = 55

                Case strKeyWord & ", spawn vehicle Bullet"

                    byteVehicleNum = 56

                Case strKeyWord & ", spawn vehicle Burrito"

                    byteVehicleNum = 57

                Case strKeyWord & ", spawn vehicle Burrito 2"

                    byteVehicleNum = 58

                Case strKeyWord & ", spawn vehicle Burrito 3"

                    byteVehicleNum = 59

                Case strKeyWord & ", spawn vehicle Burrito 4"

                    byteVehicleNum = 60

                Case strKeyWord & ", spawn vehicle Burrito 5"

                    byteVehicleNum = 61

                Case strKeyWord & ", spawn vehicle Bus"

                    byteVehicleNum = 62

                Case strKeyWord & ", spawn vehicle Buzzard"

                    byteVehicleNum = 63

                Case strKeyWord & ", spawn vehicle Buzzard 2"

                    byteVehicleNum = 64

                Case strKeyWord & ", spawn vehicle Cable Car"

                    byteVehicleNum = 65

                Case strKeyWord & ", spawn vehicle Caddy"

                    byteVehicleNum = 66

                Case strKeyWord & ", spawn vehicle Caddy 2"

                    byteVehicleNum = 67

                Case strKeyWord & ", spawn vehicle Camper"

                    byteVehicleNum = 68

                Case strKeyWord & ", spawn vehicle Carbonizzare"

                    byteVehicleNum = 69

                Case strKeyWord & ", spawn vehicle Carbon R5"

                    byteVehicleNum = 70

                Case strKeyWord & ", spawn vehicle Cargobob"

                    byteVehicleNum = 71

                Case strKeyWord & ", spawn vehicle Cargobob 2"

                    byteVehicleNum = 72

                Case strKeyWord & ", spawn vehicle Cargobob 3"

                    byteVehicleNum = 73

                Case strKeyWord & ", spawn vehicle Cargo Plane"

                    byteVehicleNum = 74

                Case strKeyWord & ", spawn vehicle Casco"

                    byteVehicleNum = 75

                Case strKeyWord & ", spawn vehicle Cavalcade"

                    byteVehicleNum = 76

                Case strKeyWord & ", spawn vehicle Cavalcade 2"

                    byteVehicleNum = 77

                Case strKeyWord & ", spawn vehicle Cheetah"

                    byteVehicleNum = 78

                Case strKeyWord & ", spawn vehicle Chino"

                    byteVehicleNum = 79

                Case strKeyWord & ", spawn vehicle Coach"

                    byteVehicleNum = 80

                Case strKeyWord & ", spawn vehicle Cognoscenti Cabrio"

                    byteVehicleNum = 81

                Case strKeyWord & ", spawn vehicle Comet"

                    byteVehicleNum = 82

                Case strKeyWord & ", spawn vehicle Coquette"

                    byteVehicleNum = 83

                Case strKeyWord & ", spawn vehicle Coquette 2"

                    byteVehicleNum = 84

                Case strKeyWord & ", spawn vehicle Coquette 3"

                    byteVehicleNum = 85

                Case strKeyWord & ", spawn vehicle Cruiser"

                    byteVehicleNum = 86

                Case strKeyWord & ", spawn vehicle Crusader"

                    byteVehicleNum = 87

                Case strKeyWord & ", spawn vehicle Cuban 800"

                    byteVehicleNum = 88

                Case strKeyWord & ", spawn vehicle Cutter"

                    byteVehicleNum = 89

                Case strKeyWord & ", spawn vehicle Daemon"

                    byteVehicleNum = 90

                Case strKeyWord & ", spawn vehicle Dilettante"

                    byteVehicleNum = 91

                Case strKeyWord & ", spawn vehicle Dilettante 2"

                    byteVehicleNum = 92

                Case strKeyWord & ", spawn vehicle Dinghy"

                    byteVehicleNum = 93

                Case strKeyWord & ", spawn vehicle Dinghy 2"

                    byteVehicleNum = 94

                Case strKeyWord & ", spawn vehicle Dinghy 3"

                    byteVehicleNum = 95

                Case strKeyWord & ", spawn vehicle D Loader"

                    byteVehicleNum = 96

                Case strKeyWord & ", spawn vehicle Dock Trailer"

                    byteVehicleNum = 97

                Case strKeyWord & ", spawn vehicle Dock Tug"

                    byteVehicleNum = 98

                Case strKeyWord & ", spawn vehicle Dodo"

                    byteVehicleNum = 99

                Case strKeyWord & ", spawn vehicle Dominator"

                    byteVehicleNum = 100

                Case strKeyWord & ", spawn vehicle Dominator 2"

                    byteVehicleNum = 101

                Case strKeyWord & ", spawn vehicle Double"

                    byteVehicleNum = 102

                Case strKeyWord & ", spawn vehicle Dubsta"

                    byteVehicleNum = 103

                Case strKeyWord & ", spawn vehicle Dubsta 2"

                    byteVehicleNum = 104

                Case strKeyWord & ", spawn vehicle Dubsta 3"

                    byteVehicleNum = 105

                Case strKeyWord & ", spawn vehicle Dukes"

                    byteVehicleNum = 106

                Case strKeyWord & ", spawn vehicle Dukes 2"

                    byteVehicleNum = 107

                Case strKeyWord & ", spawn vehicle Dump"

                    byteVehicleNum = 108

                Case strKeyWord & ", spawn vehicle Dune"

                    byteVehicleNum = 109

                Case strKeyWord & ", spawn vehicle Dune 2"

                    byteVehicleNum = 110

                Case strKeyWord & ", spawn vehicle Duster"

                    byteVehicleNum = 111

                Case strKeyWord & ", spawn vehicle Elegy"

                    byteVehicleNum = 112

                Case strKeyWord & ", spawn vehicle Emperor"

                    byteVehicleNum = 113

                Case strKeyWord & ", spawn vehicle Emperor 2"

                    byteVehicleNum = 114

                Case strKeyWord & ", spawn vehicle Emperor 3"

                    byteVehicleNum = 115

                Case strKeyWord & ", spawn vehicle Enduro"

                    byteVehicleNum = 116

                Case strKeyWord & ", spawn vehicle Entity XF"

                    byteVehicleNum = 117

                Case strKeyWord & ", spawn vehicle Exemplar"

                    byteVehicleNum = 118

                Case strKeyWord & ", spawn vehicle F 620"

                    byteVehicleNum = 119

                Case strKeyWord & ", spawn vehicle Faggio"

                    byteVehicleNum = 120

                Case strKeyWord & ", spawn vehicle FBI"

                    byteVehicleNum = 121

                Case strKeyWord & ", spawn vehicle FBI 2"

                    byteVehicleNum = 122

                Case strKeyWord & ", spawn vehicle Felon"

                    byteVehicleNum = 123

                Case strKeyWord & ", spawn vehicle Felon 2"

                    byteVehicleNum = 124

                Case strKeyWord & ", spawn vehicle Feltzer"

                    byteVehicleNum = 125

                Case strKeyWord & ", spawn vehicle Feltzer 2"

                    byteVehicleNum = 126

                Case strKeyWord & ", spawn vehicle Firetruck"

                    byteVehicleNum = 127

                Case strKeyWord & ", spawn vehicle Fixter"

                    byteVehicleNum = 128

                Case strKeyWord & ", spawn vehicle Flatbed"

                    byteVehicleNum = 129

                Case strKeyWord & ", spawn vehicle Forklift"

                    byteVehicleNum = 130

                Case strKeyWord & ", spawn vehicle Fq 2"

                    byteVehicleNum = 131

                Case strKeyWord & ", spawn vehicle Freight"

                    byteVehicleNum = 132

                Case strKeyWord & ", spawn vehicle Freight Car"

                    byteVehicleNum = 133

                Case strKeyWord & ", spawn vehicle Freight Container"

                    byteVehicleNum = 134

                Case strKeyWord & ", spawn vehicle Freight Container 2"

                    byteVehicleNum = 135

                Case strKeyWord & ", spawn vehicle Freight Grain"

                    byteVehicleNum = 136

                Case strKeyWord & ", spawn vehicle Freight Trailer"

                    byteVehicleNum = 137

                Case strKeyWord & ", spawn vehicle Frogger"

                    byteVehicleNum = 138

                Case strKeyWord & ", spawn vehicle Frogger 2"

                    byteVehicleNum = 139

                Case strKeyWord & ", spawn vehicle Fugitive"

                    byteVehicleNum = 140

                Case strKeyWord & ", spawn vehicle Furoregt"

                    byteVehicleNum = 141

                Case strKeyWord & ", spawn vehicle Fusilade"

                    byteVehicleNum = 142

                Case strKeyWord & ", spawn vehicle Futo"

                    byteVehicleNum = 143

                Case strKeyWord & ", spawn vehicle Gauntlet"

                    byteVehicleNum = 144

                Case strKeyWord & ", spawn vehicle Gauntlet 2"

                    byteVehicleNum = 145

                Case strKeyWord & ", spawn vehicle G Burrito"

                    byteVehicleNum = 146

                Case strKeyWord & ", spawn vehicle G Burrito 2"

                    byteVehicleNum = 147

                Case strKeyWord & ", spawn vehicle Glendale"

                    byteVehicleNum = 148

                Case strKeyWord & ", spawn vehicle Grain Trailer"

                    byteVehicleNum = 149

                Case strKeyWord & ", spawn vehicle Granger"

                    byteVehicleNum = 150

                Case strKeyWord & ", spawn vehicle Gresley"

                    byteVehicleNum = 151

                Case strKeyWord & ", spawn vehicle Guardian"

                    byteVehicleNum = 152

                Case strKeyWord & ", spawn vehicle Habanero"

                    byteVehicleNum = 153

                Case strKeyWord & ", spawn vehicle Hakuchou"

                    byteVehicleNum = 154

                Case strKeyWord & ", spawn vehicle Handler"

                    byteVehicleNum = 155

                Case strKeyWord & ", spawn vehicle Hauler"

                    byteVehicleNum = 156

                Case strKeyWord & ", spawn vehicle Hexer"

                    byteVehicleNum = 157

                Case strKeyWord & ", spawn vehicle Hotknife"

                    byteVehicleNum = 158

                Case strKeyWord & ", spawn vehicle Huntley"

                    byteVehicleNum = 159

                Case strKeyWord & ", spawn vehicle Hydra"

                    byteVehicleNum = 160

                Case strKeyWord & ", spawn vehicle Infernus"

                    byteVehicleNum = 161

                Case strKeyWord & ", spawn vehicle Ingot"

                    byteVehicleNum = 162

                Case strKeyWord & ", spawn vehicle Innovation"

                    byteVehicleNum = 163

                Case strKeyWord & ", spawn vehicle Insurgent"

                    byteVehicleNum = 164

                Case strKeyWord & ", spawn vehicle Insurgent 2"

                    byteVehicleNum = 165

                Case strKeyWord & ", spawn vehicle Intruder"

                    byteVehicleNum = 166

                Case strKeyWord & ", spawn vehicle Issi 2"

                    byteVehicleNum = 167

                Case strKeyWord & ", spawn vehicle Jackal"

                    byteVehicleNum = 168

                Case strKeyWord & ", spawn vehicle JB 700"

                    byteVehicleNum = 169

                Case strKeyWord & ", spawn vehicle Jester"

                    byteVehicleNum = 170

                Case strKeyWord & ", spawn vehicle Jester 2"

                    byteVehicleNum = 171

                Case strKeyWord & ", spawn vehicle Jet"

                    byteVehicleNum = 172

                Case strKeyWord & ", spawn vehicle Jetmax"

                    byteVehicleNum = 173

                Case strKeyWord & ", spawn vehicle Journey"

                    byteVehicleNum = 174

                Case strKeyWord & ", spawn vehicle Kalahari"

                    byteVehicleNum = 175

                Case strKeyWord & ", spawn vehicle Khamelion"

                    byteVehicleNum = 176

                Case strKeyWord & ", spawn vehicle Kuruma"

                    byteVehicleNum = 177

                Case strKeyWord & ", spawn vehicle Kuruma 2"

                    byteVehicleNum = 178

                Case strKeyWord & ", spawn vehicle Land Stalker"

                    byteVehicleNum = 179

                Case strKeyWord & ", spawn vehicle Laser"

                    byteVehicleNum = 180

                Case strKeyWord & ", spawn vehicle Lectro"

                    byteVehicleNum = 181

                Case strKeyWord & ", spawn vehicle L Guard"

                    byteVehicleNum = 182

                Case strKeyWord & ", spawn vehicle Luxor"

                    byteVehicleNum = 183

                Case strKeyWord & ", spawn vehicle Luxor 2"

                    byteVehicleNum = 184

                Case strKeyWord & ", spawn vehicle Mammatus"

                    byteVehicleNum = 185

                Case strKeyWord & ", spawn vehicle Manana"

                    byteVehicleNum = 186

                Case strKeyWord & ", spawn vehicle Marquis"

                    byteVehicleNum = 187

                Case strKeyWord & ", spawn vehicle Marshall"

                    byteVehicleNum = 188

                Case strKeyWord & ", spawn vehicle Massacro"

                    byteVehicleNum = 189

                Case strKeyWord & ", spawn vehicle Massacro 2"

                    byteVehicleNum = 190

                Case strKeyWord & ", spawn vehicle Maverick"

                    byteVehicleNum = 191

                Case strKeyWord & ", spawn vehicle Mesa"

                    byteVehicleNum = 192

                Case strKeyWord & ", spawn vehicle Mesa 2"

                    byteVehicleNum = 193

                Case strKeyWord & ", spawn vehicle Mesa 3"

                    byteVehicleNum = 194

                Case strKeyWord & ", spawn vehicle Miljet"

                    byteVehicleNum = 195

                Case strKeyWord & ", spawn vehicle Minivan"

                    byteVehicleNum = 196

                Case strKeyWord & ", spawn vehicle Mixer"

                    byteVehicleNum = 197

                Case strKeyWord & ", spawn vehicle Mixer 2"

                    byteVehicleNum = 198

                Case strKeyWord & ", spawn vehicle Monroe"

                    byteVehicleNum = 199

                Case strKeyWord & ", spawn vehicle Monster"

                    byteVehicleNum = 200

                Case strKeyWord & ", spawn vehicle Mower"

                    byteVehicleNum = 201

                Case strKeyWord & ", spawn vehicle Mule"

                    byteVehicleNum = 202

                Case strKeyWord & ", spawn vehicle Mule 2"

                    byteVehicleNum = 203

                Case strKeyWord & ", spawn vehicle Mule 3"

                    byteVehicleNum = 204

                Case strKeyWord & ", spawn vehicle Nemesis"

                    byteVehicleNum = 205

                Case strKeyWord & ", spawn vehicle Ninef"

                    byteVehicleNum = 206

                Case strKeyWord & ", spawn vehicle Ninef 2"

                    byteVehicleNum = 207

                Case strKeyWord & ", spawn vehicle Oracle"

                    byteVehicleNum = 208

                Case strKeyWord & ", spawn vehicle Oracle 2"

                    byteVehicleNum = 209

                Case strKeyWord & ", spawn vehicle Osiris"

                    byteVehicleNum = 210

                Case strKeyWord & ", spawn vehicle Packer"

                    byteVehicleNum = 211

                Case strKeyWord & ", spawn vehicle Panto"

                    byteVehicleNum = 212

                Case strKeyWord & ", spawn vehicle Paradise"

                    byteVehicleNum = 213

                Case strKeyWord & ", spawn vehicle Patriot"

                    byteVehicleNum = 214

                Case strKeyWord & ", spawn vehicle P Bus"

                    byteVehicleNum = 215

                Case strKeyWord & ", spawn vehicle PCJ"

                    byteVehicleNum = 216

                Case strKeyWord & ", spawn vehicle Penumbra"

                    byteVehicleNum = 217

                Case strKeyWord & ", spawn vehicle Peyote"

                    byteVehicleNum = 218

                Case strKeyWord & ", spawn vehicle Phantom"

                    byteVehicleNum = 219

                Case strKeyWord & ", spawn vehicle Phoenix"

                    byteVehicleNum = 220

                Case strKeyWord & ", spawn vehicle Picador"

                    byteVehicleNum = 221

                Case strKeyWord & ", spawn vehicle Pigalle"

                    byteVehicleNum = 222

                Case strKeyWord & ", spawn vehicle Police"

                    byteVehicleNum = 223

                Case strKeyWord & ", spawn vehicle Police 2"

                    byteVehicleNum = 224

                Case strKeyWord & ", spawn vehicle Police 3"

                    byteVehicleNum = 225

                Case strKeyWord & ", spawn vehicle Police 4"

                    byteVehicleNum = 226

                Case strKeyWord & ", spawn vehicle Police B"

                    byteVehicleNum = 227

                Case strKeyWord & ", spawn vehicle Police Old"

                    byteVehicleNum = 228

                Case strKeyWord & ", spawn vehicle Police Old 2"

                    byteVehicleNum = 229

                Case strKeyWord & ", spawn vehicle Police T"

                    byteVehicleNum = 230

                Case strKeyWord & ", spawn vehicle Polmav"

                    byteVehicleNum = 231

                Case strKeyWord & ", spawn vehicle Pony"

                    byteVehicleNum = 232

                Case strKeyWord & ", spawn vehicle Pony 2"

                    byteVehicleNum = 233

                Case strKeyWord & ", spawn vehicle Pounder"

                    byteVehicleNum = 234

                Case strKeyWord & ", spawn vehicle Prairie"

                    byteVehicleNum = 235

                Case strKeyWord & ", spawn vehicle Pranger"

                    byteVehicleNum = 236

                Case strKeyWord & ", spawn vehicle Predator"

                    byteVehicleNum = 237

                Case strKeyWord & ", spawn vehicle Premier"

                    byteVehicleNum = 238

                Case strKeyWord & ", spawn vehicle Primo"

                    byteVehicleNum = 239

                Case strKeyWord & ", spawn vehicle Prop Trailer"

                    byteVehicleNum = 240

                Case strKeyWord & ", spawn vehicle Radi"

                    byteVehicleNum = 241

                Case strKeyWord & ", spawn vehicle Rake Trailer"

                    byteVehicleNum = 242

                Case strKeyWord & ", spawn vehicle Rancher XL"

                    byteVehicleNum = 243

                Case strKeyWord & ", spawn vehicle Rancher XL 2"

                    byteVehicleNum = 244

                Case strKeyWord & ", spawn vehicle Rapid GT"

                    byteVehicleNum = 245

                Case strKeyWord & ", spawn vehicle Rapid GT 2"

                    byteVehicleNum = 246

                Case strKeyWord & ", spawn vehicle Rat Loader"

                    byteVehicleNum = 247

                Case strKeyWord & ", spawn vehicle Rat Loader 2"

                    byteVehicleNum = 248

                Case strKeyWord & ", spawn vehicle Rebel"

                    byteVehicleNum = 249

                Case strKeyWord & ", spawn vehicle Rebel 2"

                    byteVehicleNum = 250

                Case strKeyWord & ", spawn vehicle Regina"

                    byteVehicleNum = 251

                Case strKeyWord & ", spawn vehicle Rental Bus"

                    byteVehicleNum = 252

                Case strKeyWord & ", spawn vehicle Rhapsody"

                    byteVehicleNum = 253

                Case strKeyWord & ", spawn vehicle Rhino"

                    byteVehicleNum = 254

                Case strKeyWord & ", spawn vehicle Riot"

                    byteVehicleNum = 255

                Case strKeyWord & ", spawn vehicle Ripley"

                    byteVehicleNum = 256

                Case strKeyWord & ", spawn vehicle Rocoto"

                    byteVehicleNum = 257

                Case strKeyWord & ", spawn vehicle Romero"

                    byteVehicleNum = 258

                Case strKeyWord & ", spawn vehicle Rubble"

                    byteVehicleNum = 259

                Case strKeyWord & ", spawn vehicle Ruffian"

                    byteVehicleNum = 260

                Case strKeyWord & ", spawn vehicle Ruiner"

                    byteVehicleNum = 261

                Case strKeyWord & ", spawn vehicle Rumpo"

                    byteVehicleNum = 262

                Case strKeyWord & ", spawn vehicle Rumpo 2"

                    byteVehicleNum = 263

                Case strKeyWord & ", spawn vehicle Sabre GT"

                    byteVehicleNum = 264

                Case strKeyWord & ", spawn vehicle Sadler"

                    byteVehicleNum = 265

                Case strKeyWord & ", spawn vehicle Sadler 2"

                    byteVehicleNum = 266

                Case strKeyWord & ", spawn vehicle Sanchez"

                    byteVehicleNum = 267

                Case strKeyWord & ", spawn vehicle Sanchez 2"

                    byteVehicleNum = 268

                Case strKeyWord & ", spawn vehicle Sandking"

                    byteVehicleNum = 269

                Case strKeyWord & ", spawn vehicle Sandking 2"

                    byteVehicleNum = 270

                Case strKeyWord & ", spawn vehicle Savage"

                    byteVehicleNum = 271

                Case strKeyWord & ", spawn vehicle Schafter"

                    byteVehicleNum = 272

                Case strKeyWord & ", spawn vehicle Schwarzer"

                    byteVehicleNum = 273

                Case strKeyWord & ", spawn vehicle Scorcher"

                    byteVehicleNum = 274

                Case strKeyWord & ", spawn vehicle Scrap"

                    byteVehicleNum = 275

                Case strKeyWord & ", spawn vehicle Sea Shark"

                    byteVehicleNum = 276

                Case strKeyWord & ", spawn vehicle Sea Shark 2"

                    byteVehicleNum = 277

                Case strKeyWord & ", spawn vehicle Seminole"

                    byteVehicleNum = 278

                Case strKeyWord & ", spawn vehicle Sentinal"

                    byteVehicleNum = 279

                Case strKeyWord & ", spawn vehicle Sentinal 2"

                    byteVehicleNum = 280

                Case strKeyWord & ", spawn vehicle Serrano"

                    byteVehicleNum = 281

                Case strKeyWord & ", spawn vehicle Shamal"

                    byteVehicleNum = 282

                Case strKeyWord & ", spawn vehicle Sheriff"

                    byteVehicleNum = 283

                Case strKeyWord & ", spawn vehicle Sheriff 2"

                    byteVehicleNum = 284

                Case strKeyWord & ", spawn vehicle Skylift"

                    byteVehicleNum = 285

                Case strKeyWord & ", spawn vehicle Skylift 2"

                    byteVehicleNum = 286

                Case strKeyWord & ", spawn vehicle Slam Van"

                    byteVehicleNum = 287

                Case strKeyWord & ", spawn vehicle Slam Van 2"

                    byteVehicleNum = 288

                Case strKeyWord & ", spawn vehicle Sovereign"

                    byteVehicleNum = 289

                Case strKeyWord & ", spawn vehicle Speeder"

                    byteVehicleNum = 290

                Case strKeyWord & ", spawn vehicle Speedo"

                    byteVehicleNum = 291

                Case strKeyWord & ", spawn vehicle Speedo 2"

                    byteVehicleNum = 292

                Case strKeyWord & ", spawn vehicle Squalo"

                    byteVehicleNum = 293

                Case strKeyWord & ", spawn vehicle Stalion"

                    byteVehicleNum = 294

                Case strKeyWord & ", spawn vehicle Stalion 2"

                    byteVehicleNum = 295

                Case strKeyWord & ", spawn vehicle Stanier"

                    byteVehicleNum = 296

                Case strKeyWord & ", spawn vehicle Stinger"

                    byteVehicleNum = 297

                Case strKeyWord & ", spawn vehicle Stinger GT"

                    byteVehicleNum = 298

                Case strKeyWord & ", spawn vehicle Stockade"

                    byteVehicleNum = 299

                Case strKeyWord & ", spawn vehicle Stockade 2"

                    byteVehicleNum = 300

                Case strKeyWord & ", spawn vehicle Stratum"

                    byteVehicleNum = 301

                Case strKeyWord & ", spawn vehicle Stretch"

                    byteVehicleNum = 302

                Case strKeyWord & ", spawn vehicle Stunt"

                    byteVehicleNum = 303

                Case strKeyWord & ", spawn vehicle Submersible"

                    byteVehicleNum = 304

                Case strKeyWord & ", spawn vehicle Submersible 2"

                    byteVehicleNum = 305

                Case strKeyWord & ", spawn vehicle Sultan"

                    byteVehicleNum = 306

                Case strKeyWord & ", spawn vehicle Suntrap"

                    byteVehicleNum = 307

                Case strKeyWord & ", spawn vehicle Super Diamond"

                    byteVehicleNum = 308

                Case strKeyWord & ", spawn vehicle Surano"

                    byteVehicleNum = 309

                Case strKeyWord & ", spawn vehicle Surfer"

                    byteVehicleNum = 310

                Case strKeyWord & ", spawn vehicle Surfer 2"

                    byteVehicleNum = 311

                Case strKeyWord & ", spawn vehicle Surge"

                    byteVehicleNum = 312

                Case strKeyWord & ", spawn vehicle Swift"

                    byteVehicleNum = 313

                Case strKeyWord & ", spawn vehicle Swift 2"

                    byteVehicleNum = 314

                Case strKeyWord & ", spawn vehicle T 20"

                    byteVehicleNum = 315

                Case strKeyWord & ", spawn vehicle Taco"

                    byteVehicleNum = 316

                Case strKeyWord & ", spawn vehicle Tailgater"

                    byteVehicleNum = 317

                Case strKeyWord & ", spawn vehicle Tanker"

                    byteVehicleNum = 318

                Case strKeyWord & ", spawn vehicle Tanker 2"

                    byteVehicleNum = 319

                Case strKeyWord & ", spawn vehicle Tanker Car"

                    byteVehicleNum = 320

                Case strKeyWord & ", spawn vehicle Taxi"

                    byteVehicleNum = 321

                Case strKeyWord & ", spawn vehicle Technical"

                    byteVehicleNum = 322

                Case strKeyWord & ", spawn vehicle Thrust"

                    byteVehicleNum = 323

                Case strKeyWord & ", spawn vehicle Tip Truck"

                    byteVehicleNum = 324

                Case strKeyWord & ", spawn vehicle Tip Truck 2"

                    byteVehicleNum = 325

                Case strKeyWord & ", spawn vehicle Titan"

                    byteVehicleNum = 326

                Case strKeyWord & ", spawn vehicle Tornado"

                    byteVehicleNum = 327

                Case strKeyWord & ", spawn vehicle Tornado 2"

                    byteVehicleNum = 328

                Case strKeyWord & ", spawn vehicle Tornado 3"

                    byteVehicleNum = 329

                Case strKeyWord & ", spawn vehicle Tornado 4"

                    byteVehicleNum = 330

                Case strKeyWord & ", spawn vehicle Toro"

                    byteVehicleNum = 331

                Case strKeyWord & ", spawn vehicle Tour Bus"

                    byteVehicleNum = 332

                Case strKeyWord & ", spawn vehicle Tow Truck"

                    byteVehicleNum = 333

                Case strKeyWord & ", spawn vehicle Tow Truck 2"

                    byteVehicleNum = 334

                Case strKeyWord & ", spawn vehicle TR"

                    byteVehicleNum = 335

                Case strKeyWord & ", spawn vehicle TR 2"

                    byteVehicleNum = 336

                Case strKeyWord & ", spawn vehicle TR 3"

                    byteVehicleNum = 337

                Case strKeyWord & ", spawn vehicle TR 4"

                    byteVehicleNum = 338

                Case strKeyWord & ", spawn vehicle Tractor"

                    byteVehicleNum = 339

                Case strKeyWord & ", spawn vehicle Tractor 2"

                    byteVehicleNum = 340

                Case strKeyWord & ", spawn vehicle Tractor 3"

                    byteVehicleNum = 341

                Case strKeyWord & ", spawn vehicle Trailer Logs"

                    byteVehicleNum = 342

                Case strKeyWord & ", spawn vehicle Trailers"

                    byteVehicleNum = 343

                Case strKeyWord & ", spawn vehicle Trailers 2"

                    byteVehicleNum = 344

                Case strKeyWord & ", spawn vehicle Trailers 3"

                    byteVehicleNum = 345

                Case strKeyWord & ", spawn vehicle Trailer Small"

                    byteVehicleNum = 346

                Case strKeyWord & ", spawn vehicle Trash"

                    byteVehicleNum = 347

                Case strKeyWord & ", spawn vehicle Trash 2"

                    byteVehicleNum = 348

                Case strKeyWord & ", spawn vehicle TR Flat"

                    byteVehicleNum = 349

                Case strKeyWord & ", spawn vehicle Tri Bike"

                    byteVehicleNum = 350

                Case strKeyWord & ", spawn vehicle Tri Bike 2"

                    byteVehicleNum = 351

                Case strKeyWord & ", spawn vehicle Tri Bike 3"

                    byteVehicleNum = 352

                Case strKeyWord & ", spawn vehicle Tropic"

                    byteVehicleNum = 353

                Case strKeyWord & ", spawn vehicle Turismor"

                    byteVehicleNum = 354

                Case strKeyWord & ", spawn vehicle TV Trailer"

                    byteVehicleNum = 355

                Case strKeyWord & ", spawn vehicle Utility Truck"

                    byteVehicleNum = 356

                Case strKeyWord & ", spawn vehicle Utility Truck 2"

                    byteVehicleNum = 357

                Case strKeyWord & ", spawn vehicle Utility Truck 3"

                    byteVehicleNum = 358

                Case strKeyWord & ", spawn vehicle Utilli Truck"

                    byteVehicleNum = 359

                Case strKeyWord & ", spawn vehicle Utilli Truck 2"

                    byteVehicleNum = 360

                Case strKeyWord & ", spawn vehicle Utilli Truck 3"

                    byteVehicleNum = 361

                Case strKeyWord & ", spawn vehicle Vacca"

                    byteVehicleNum = 362

                Case strKeyWord & ", spawn vehicle Vader"

                    byteVehicleNum = 363

                Case strKeyWord & ", spawn vehicle Valkyrie"

                    byteVehicleNum = 364

                Case strKeyWord & ", spawn vehicle Velum"

                    byteVehicleNum = 365

                Case strKeyWord & ", spawn vehicle Velum 2"

                    byteVehicleNum = 366

                Case strKeyWord & ", spawn vehicle Vestra"

                    byteVehicleNum = 367

                Case strKeyWord & ", spawn vehicle Vigero"

                    byteVehicleNum = 368

                Case strKeyWord & ", spawn vehicle Vindicator"

                    byteVehicleNum = 369

                Case strKeyWord & ", spawn vehicle Virgo"

                    byteVehicleNum = 370

                Case strKeyWord & ", spawn vehicle Voltic"

                    byteVehicleNum = 371

                Case strKeyWord & ", spawn vehicle Voodoo"

                    byteVehicleNum = 372

                Case strKeyWord & ", spawn vehicle Warrener"

                    byteVehicleNum = 373

                Case strKeyWord & ", spawn vehicle Washington"

                    byteVehicleNum = 374

                Case strKeyWord & ", spawn vehicle Windsor"

                    byteVehicleNum = 375

                Case strKeyWord & ", spawn vehicle Youga"

                    byteVehicleNum = 376

                Case strKeyWord & ", spawn vehicle Zentorno"

                    byteVehicleNum = 377

                Case strKeyWord & ", spawn vehicle Zion"

                    byteVehicleNum = 378

                Case strKeyWord & ", spawn vehicle Zion 2"

                    byteVehicleNum = 379

                Case strKeyWord & ", spawn vehicle Z Type"

                    byteVehicleNum = 380

                Case strKeyWord & ", spawn vehicle random"

                    byteVehicleNum = Int((380 + 1) * Rnd())

            End Select

        End If

    End Sub

    Public Sub Update(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Tick

        Try

            If Game.Player.Character.IsAlive Then

                If intVehiclePrimaryColorType = 0 And boolShowVehiclePrimaryColor = True Then

                    colVehiclePrimaryColor = Color.White

                    boolShowVehiclePrimaryColor = False

                ElseIf intVehiclePrimaryColorType = 1 And boolShowVehiclePrimaryColor = True

                    colVehiclePrimaryColor = Color.Black

                    boolShowVehiclePrimaryColor = False

                ElseIf intVehiclePrimaryColorType = 2 And boolShowVehiclePrimaryColor = True

                    colVehiclePrimaryColor = Color.Red

                    boolShowVehiclePrimaryColor = False

                ElseIf intVehiclePrimaryColorType = 3 And boolShowVehiclePrimaryColor = True

                    colVehiclePrimaryColor = Color.Orange

                    boolShowVehiclePrimaryColor = False

                ElseIf intVehiclePrimaryColorType = 4 And boolShowVehiclePrimaryColor = True

                    colVehiclePrimaryColor = Color.Yellow

                    boolShowVehiclePrimaryColor = False

                ElseIf intVehiclePrimaryColorType = 5 And boolShowVehiclePrimaryColor = True

                    colVehiclePrimaryColor = Color.Green

                    boolShowVehiclePrimaryColor = False

                ElseIf intVehiclePrimaryColorType = 6 And boolShowVehiclePrimaryColor = True

                    colVehiclePrimaryColor = Color.Blue

                    boolShowVehiclePrimaryColor = False

                ElseIf intVehiclePrimaryColorType = 7 And boolShowVehiclePrimaryColor = True

                    colVehiclePrimaryColor = Color.Purple

                    boolShowVehiclePrimaryColor = False

                ElseIf intVehiclePrimaryColorType = 8 And boolShowVehiclePrimaryColor = True

                    colVehiclePrimaryColor = Color.Pink

                    boolShowVehiclePrimaryColor = False

                End If

                If intVehicleSecondaryColorType = 0 And boolShowVehicleSecondaryColor = True Then

                    colVehicleSecondaryColor = Color.White

                    boolShowVehicleSecondaryColor = False

                ElseIf intVehicleSecondaryColorType = 1 And boolShowVehicleSecondaryColor = True

                    colVehicleSecondaryColor = Color.Black

                    boolShowVehicleSecondaryColor = False

                ElseIf intVehicleSecondaryColorType = 2 And boolShowVehicleSecondaryColor = True

                    colVehicleSecondaryColor = Color.Red

                    boolShowVehicleSecondaryColor = False

                ElseIf intVehicleSecondaryColorType = 3 And boolShowVehicleSecondaryColor = True

                    colVehicleSecondaryColor = Color.Orange

                    boolShowVehicleSecondaryColor = False

                ElseIf intVehicleSecondaryColorType = 4 And boolShowVehicleSecondaryColor = True

                    colVehicleSecondaryColor = Color.Yellow

                    boolShowVehicleSecondaryColor = False

                ElseIf intVehicleSecondaryColorType = 5 And boolShowVehicleSecondaryColor = True

                    colVehicleSecondaryColor = Color.Green

                    boolShowVehicleSecondaryColor = False

                ElseIf intVehicleSecondaryColorType = 6 And boolShowVehicleSecondaryColor = True

                    colVehicleSecondaryColor = Color.Blue

                    boolShowVehicleSecondaryColor = False

                ElseIf intVehicleSecondaryColorType = 7 And boolShowVehicleSecondaryColor = True

                    colVehicleSecondaryColor = Color.Purple

                    boolShowVehicleSecondaryColor = False

                ElseIf intVehicleSecondaryColorType = 8 And boolShowVehicleSecondaryColor = True

                    colVehicleSecondaryColor = Color.Pink

                    boolShowVehicleSecondaryColor = False

                End If

                Select Case byteVehicleNum

                    Case 0

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Adder, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Adder spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Adder spawned")

                        End If

                    Case 1

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Airbus, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Airbus spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Airbus spawned")

                        End If

                    Case 2

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Airtug, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Airtug spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Airtug spawned")

                        End If

                    Case 3

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Akuma, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Akuma spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Akuma spawned")

                        End If

                    Case 4

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Alpha, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Alpha spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Alpha spawned")

                        End If

                    Case 5

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Ambulance, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Ambulance spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Ambulance spawned")

                        End If

                    Case 6

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Annihilator, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Annihilator spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Annihilator spawned")

                        End If

                    Case 7

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.ArmyTanker, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Army Tanker spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Army Tanker spawned")

                        End If

                    Case 8

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.ArmyTrailer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Army Trailer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Army Trailer spawned")

                        End If

                    Case 9

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.ArmyTrailer2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Army Trailer 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Army Trailer 2 spawned")

                        End If

                    Case 10

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Asea, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Asea spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Asea spawned")

                        End If

                    Case 11

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Asea2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Asea 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Asea 2 spawned")

                        End If

                    Case 12

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Asterope, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Asterope spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Asterope spawned")

                        End If

                    Case 13

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Bagger, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Bagger spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Bagger spawned")

                        End If

                    Case 14

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.BaleTrailer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Bale Trailer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Bale Trailer spawned")

                        End If

                    Case 15

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Baller, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Baller spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Baller spawned")

                        End If

                    Case 16

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Baller2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Baller 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Baller 2 spawned")

                        End If

                    Case 17

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Banshee, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Banshee spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Banshee spawned")

                        End If

                    Case 18

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Barracks, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Barracks spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Barracks spawned")

                        End If

                    Case 19

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Barracks2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Barracks 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Barracks 2 spawned")

                        End If

                    Case 20

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Barracks3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Barracks 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Barracks 3 spawned")

                        End If

                    Case 21

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Bati, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Bati spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Bati spawned")

                        End If

                    Case 22

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Bati2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Bati 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Bati 2 spawned")

                        End If

                    Case 23

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Benson, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Benson spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Benson spawned")

                        End If

                    Case 24

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Besra, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Besra spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Besra spawned")

                        End If

                    Case 25

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.BfInjection, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Bf Injection spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Bf Injection spawned")

                        End If

                    Case 26

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Biff, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Biff spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Biff spawned")

                        End If

                    Case 27

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Bifta, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Bifta spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Bifta spawned")

                        End If

                    Case 28

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Bison, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Bison spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Bison spawned")

                        End If

                    Case 29

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Bison2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Bison 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Bison 2 spawned")

                        End If

                    Case 30

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Bison3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Bison 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Bison 3 spawned")

                        End If

                    Case 31

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.BJXL, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("BJXL spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("BJXL spawned")

                        End If

                    Case 32

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Blade, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Blade spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Blade spawned")

                        End If

                    Case 33

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Blazer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Blazer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Blazer spawned")

                        End If

                    Case 34

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Blazer2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Blazer 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Blazer 2 spawned")

                        End If

                    Case 35

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Blazer3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Blazer 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Blazer 3 spawned")

                        End If

                    Case 36

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Blimp, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Blimp spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Blimp spawned")

                        End If

                    Case 37

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Blimp2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Blimp 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Blimp 2 spawned")

                        End If

                    Case 38

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Blista, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Blista spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Blista spawned")

                        End If

                    Case 39

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Blista2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Blista 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Blista 2 spawned")

                        End If

                    Case 40

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Blista3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Blista 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Blista 3 spawned")

                        End If

                    Case 41

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Bmx, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Bmx spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Bmx spawned")

                        End If

                    Case 42

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.BoatTrailer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Boat Trailer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Boat Trailer spawned")

                        End If

                    Case 43

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.BobcatXL, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Bobcat XL spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Bobcat XL spawned")

                        End If

                    Case 44

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Bodhi2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Bodhi spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Bodhi spawned")

                        End If

                    Case 45

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Boxville, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Boxville spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Boxville spawned")

                        End If

                    Case 46

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Boxville2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Boxville 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Boxville 2 spawned")

                        End If

                    Case 47

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Boxville3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Boxville 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Boxville 3 spawned")

                        End If

                    Case 48

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Boxville4, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Boxville 4 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Boxville 4 spawned")

                        End If

                    Case 49

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Brawler, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Brawler spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Brawler spawned")

                        End If

                    Case 50

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.BType, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("B Type spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("B Type spawned")

                        End If

                    Case 51

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Buccaneer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Buccaneer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Buccaneer spawned")

                        End If

                    Case 52

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Buffalo, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Buffalo spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Buffalo spawned")

                        End If

                    Case 53

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Buffalo2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Buffalo 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Buffalo 2 spawned")

                        End If

                    Case 54

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Buffalo3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Buffalo 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Buffalo 3 spawned")

                        End If

                    Case 55

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Bulldozer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Bulldozer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Bulldozer spawned")

                        End If

                    Case 56

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Bullet, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Bullet spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Bullet spawned")

                        End If

                    Case 57

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Burrito, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Burrito spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Burrito spawned")

                        End If

                    Case 58

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Burrito2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Burrito 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Burrito 2 spawned")

                        End If

                    Case 59

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Burrito3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Burrito 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Burrito 3 spawned")

                        End If

                    Case 60

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Burrito4, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Burrito 4 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Burrito 4 spawned")

                        End If

                    Case 61

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Burrito5, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Burrito 5 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Burrito 5 spawned")

                        End If

                    Case 62

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Bus, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Bus spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Bus spawned")

                        End If

                    Case 63

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Buzzard, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Buzzard spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Buzzard spawned")

                        End If

                    Case 64

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Buzzard2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Buzzard 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Buzzard 2 spawned")

                        End If

                    Case 65

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.CableCar, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Cable Car spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Cable Car spawned")

                        End If

                    Case 66

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Caddy, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Caddy spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Caddy spawned")

                        End If

                    Case 67

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Caddy2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Caddy 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Caddy 2 spawned")

                        End If

                    Case 68

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Camper, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Camper spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Camper spawned")

                        End If

                    Case 69

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Carbonizzare, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Carbonizzare spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Carbonizzare spawned")

                        End If

                    Case 70

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.CarbonRS, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Carbon RS spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Carbon RS spawned")

                        End If

                    Case 71

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Cargobob, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Cargobob spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Cargobob spawned")

                        End If

                    Case 72

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Cargobob2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Cargobob 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Cargobob 2 spawned")

                        End If

                    Case 73

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Cargobob3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Cargobob 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Cargobob 3 spawned")

                        End If

                    Case 74

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.CargoPlane, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Cargo Plane spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Cargo Plane spawned")

                        End If

                    Case 75

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Casco, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Casco spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Casco spawned")

                        End If

                    Case 76

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Cavalcade, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Cavalcade spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Cavalcade spawned")

                        End If

                    Case 77

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Cavalcade2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Cavalcade 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Cavalcade 2 spawned")

                        End If

                    Case 78

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Cheetah, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Cheetah spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Cheetah spawned")

                        End If

                    Case 79

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Chino, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Chino spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Chino spawned")

                        End If

                    Case 80

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Coach, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Coach spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Coach spawned")

                        End If

                    Case 81

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.CogCabrio, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Cognoscenti Cabrio spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Cognoscenti Cabrio spawned")

                        End If

                    Case 82

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Comet2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Comet spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Comet spawned")

                        End If

                    Case 83

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Coquette, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Coquette spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Coquette spawned")

                        End If

                    Case 84

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Coquette2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Coquette 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Coquette 2 spawned")

                        End If

                    Case 85

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Coquette3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Coquette 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Coquette 3 spawned")

                        End If

                    Case 86

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Cruiser, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Cruiser spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Cruiser spawned")

                        End If

                    Case 87

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Crusader, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Crusader spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Crusader spawned")

                        End If

                    Case 88

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Cuban800, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Cuban 800 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Cuban 800 spawned")

                        End If

                    Case 89

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Cutter, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Cutter spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Cutter spawned")

                        End If

                    Case 90

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Daemon, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Daemon spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Daemon spawned")

                        End If

                    Case 91

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dilettante, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dilettante spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dilettante spawned")

                        End If

                    Case 92

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dilettante2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dilettante 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dilettante 2 spawned")

                        End If

                    Case 93

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dinghy, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dinghy spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dinghy spawned")

                        End If

                    Case 94

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dinghy2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dinghy 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dinghy 2 spawned")

                        End If

                    Case 95

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dinghy3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dinghy 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dinghy 3 spawned")

                        End If

                    Case 96

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.DLoader, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("D Loader spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("D Loader spawned")

                        End If

                    Case 97

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.DockTrailer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dock Trailer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dock Trailer spawned")

                        End If

                    Case 98

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Docktug, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dock Tug spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dock Tug spawned")

                        End If

                    Case 99

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dodo, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dodo spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dodo spawned")

                        End If

                    Case 100

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dominator, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dominator spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dominator spawned")

                        End If

                    Case 101

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dominator2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dominator 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dominator 2 spawned")

                        End If

                    Case 102

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Double, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Double spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Double spawned")

                        End If

                    Case 103

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dubsta, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dubsta spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dubsta spawned")

                        End If

                    Case 104

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dubsta2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dubsta 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dubsta 2 spawned")

                        End If

                    Case 105

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dubsta3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dubsta 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dubsta 3 spawned")

                        End If

                    Case 106

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dukes, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dukes spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dukes spawned")

                        End If

                    Case 107

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dukes2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dukes 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dukes 2 spawned")

                        End If

                    Case 108

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dump, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dump spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dump spawned")

                        End If

                    Case 109

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dune, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dune spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dune spawned")

                        End If

                    Case 110

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Dune2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Dune 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Dune 2 spawned")

                        End If

                    Case 111

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Duster, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Duster spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Duster spawned")

                        End If

                    Case 112

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Elegy2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Elegy spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Elegy spawned")

                        End If

                    Case 113

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Emperor, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Emperor spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Emperor spawned")

                        End If

                    Case 114

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Emperor2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Emperor 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Emperor 2 spawned")

                        End If

                    Case 115

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Emperor3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Emperor 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Emperor 3 spawned")

                        End If

                    Case 116

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Enduro, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Enduro spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Enduro spawned")

                        End If

                    Case 117

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.EntityXF, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Entity XF spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Entity XF spawned")

                        End If

                    Case 118

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Exemplar, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Exemplar spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Exemplar spawned")

                        End If

                    Case 119

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.F620, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("F 620 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("F 620 spawned")

                        End If

                    Case 120

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Faggio2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Faggio spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Faggio spawned")

                        End If

                    Case 121

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.FBI, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("FBI spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("FBI spawned")

                        End If

                    Case 122

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.FBI2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("FBI 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("FBI 2 spawned")

                        End If

                    Case 123

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Felon, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Felon spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Felon spawned")

                        End If

                    Case 124

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Felon2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Felon 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Felon 2 spawned")

                        End If

                    Case 125

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Feltzer2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Feltzer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Feltzer spawned")

                        End If

                    Case 126

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Feltzer3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Feltzer 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Feltzer 2 spawned")

                        End If

                    Case 127

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.FireTruck, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Firetruck spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Firetruck spawned")

                        End If

                    Case 128

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Fixter, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Fixter spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Fixter spawned")

                        End If

                    Case 129

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Flatbed, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Flatbed spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Flatbed spawned")

                        End If

                    Case 130

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Forklift, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Forklift spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Forklift spawned")

                        End If

                    Case 131

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Fq2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Fq 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Fq 2 spawned")

                        End If

                    Case 132

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Freight, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Freight spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Freight spawned")

                        End If

                    Case 133

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.FreightCar, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Freight Car spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Freight Car spawned")

                        End If

                    Case 134

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.FreightCont1, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Freight Container spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Freight Container spawned")

                        End If

                    Case 135

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.FreightCont2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Freight Container 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Freight Container 2 spawned")

                        End If

                    Case 136

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.FreightGrain, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Freight Grain spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Freight Grain spawned")

                        End If

                    Case 137

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.FreightTrailer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Freight Trailer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Freight Trailer spawned")

                        End If

                    Case 138

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Frogger, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Frogger spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Frogger spawned")

                        End If

                    Case 139

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Frogger2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Frogger 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Frogger 2 spawned")

                        End If

                    Case 140

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Fugitive, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Fugitive spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Fugitive spawned")

                        End If

                    Case 141

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Furoregt, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Furoregt spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Furoregt spawned")

                        End If

                    Case 142

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Fusilade, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Fusilade spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Fusilade spawned")

                        End If

                    Case 143

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Futo, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Futo spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Futo spawned")

                        End If

                    Case 144

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Gauntlet, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Gauntlet spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Gauntlet spawned")

                        End If

                    Case 145

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Gauntlet2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Gauntlet 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Gauntlet 2 spawned")

                        End If

                    Case 146

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.GBurrito, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("G Burrito spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("G Burrito spawned")

                        End If

                    Case 147

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.GBurrito2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("G Burrito 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("G Burrito 2 spawned")

                        End If

                    Case 148

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Glendale, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Glendale spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Glendale spawned")

                        End If

                    Case 149

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.GrainTrailer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Grain Trailer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Grain Trailer spawned")

                        End If

                    Case 150

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Granger, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Granger spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Granger spawned")

                        End If

                    Case 151

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Gresley, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Gresley spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Gresley spawned")

                        End If

                    Case 152

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Guardian, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Guardian spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Guardian spawned")

                        End If

                    Case 153

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Habanero, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Habanero spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Habanero spawned")

                        End If

                    Case 154

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Hakuchou, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Hakuchou spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Hakuchou spawned")

                        End If

                    Case 155

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Handler, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Handler spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Handler spawned")

                        End If

                    Case 156

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Hauler, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Hauler spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Hauler spawned")

                        End If

                    Case 157

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Hexer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Hexer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Hexer spawned")

                        End If

                    Case 158

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Hotknife, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Hotknife spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Hotknife spawned")

                        End If

                    Case 159

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Huntley, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Huntley spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Huntley spawned")

                        End If

                    Case 160

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Hydra, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Hydra spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Hydra spawned")

                        End If

                    Case 161

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Infernus, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Infernus spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Infernus spawned")

                        End If

                    Case 162

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Ingot, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Ingot spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Ingot spawned")

                        End If

                    Case 163

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Innovation, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Innovation spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Innovation spawned")

                        End If

                    Case 164

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Insurgent, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Insurgent spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Insurgent spawned")

                        End If

                    Case 165

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Insurgent2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Insurgent 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Insurgent 2 spawned")

                        End If

                    Case 166

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Intruder, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Intruder spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Intruder spawned")

                        End If

                    Case 167

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Issi2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Issi 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Issi 2 spawned")

                        End If

                    Case 168

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Jackal, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Jackal spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Jackal spawned")

                        End If

                    Case 169

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.JB700, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("JB 700 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("JB 700 spawned")

                        End If

                    Case 170

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Jester, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Jester spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Jester spawned")

                        End If

                    Case 171

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Jester2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Jester 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Jester 2 spawned")

                        End If

                    Case 172

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Jet, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Jet spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Jet spawned")

                        End If

                    Case 173

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Jetmax, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Jetmax spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Jetmax spawned")

                        End If

                    Case 174

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Journey, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Journey spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Journey spawned")

                        End If

                    Case 175

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Kalahari, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Kalahari spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Kalahari spawned")

                        End If

                    Case 176

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Khamelion, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Khamelion spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Khamelion spawned")

                        End If

                    Case 177

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Kuruma, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Kuruma spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Kuruma spawned")

                        End If

                    Case 178

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Kuruma2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Kuruma 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Kuruma 2 spawned")

                        End If

                    Case 179

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Landstalker, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Land Stalker spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Land Stalker spawned")

                        End If

                    Case 180

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Lazer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Lazer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Lazer spawned")

                        End If

                    Case 181

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Lectro, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Lectro spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Lectro spawned")

                        End If

                    Case 182

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Lguard, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("L Guard spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("L Guard spawned")

                        End If

                    Case 183

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Luxor, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Luxor spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Luxor spawned")

                        End If

                    Case 184

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Luxor2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Luxor 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Luxor 2 spawned")

                        End If

                    Case 185

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Mammatus, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Mammatus spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Mammatus spawned")

                        End If

                    Case 186

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Manana, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Manana spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Manana spawned")

                        End If

                    Case 187

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Marquis, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Marquis spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Marquis spawned")

                        End If

                    Case 188

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Marshall, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Marshall spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Marshall spawned")

                        End If

                    Case 189

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Massacro, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Massacro spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Massacro spawned")

                        End If

                    Case 190

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Massacro2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Massacro 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Massacro 2 spawned")

                        End If

                    Case 191

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Maverick, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Maverick spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Maverick spawned")

                        End If

                    Case 192

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Mesa, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Mesa spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Mesa spawned")

                        End If

                    Case 193

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Mesa2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Mesa 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Mesa 2 spawned")

                        End If

                    Case 194

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Mesa3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Mesa 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Mesa 3 spawned")

                        End If

                    Case 195

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Miljet, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Miljet spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Miljet spawned")

                        End If

                    Case 196

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Minivan, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Minivan spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Minivan spawned")

                        End If

                    Case 197

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Mixer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Mixer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Mixer spawned")

                        End If

                    Case 198

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Mixer2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Mixer 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Mixer 2 spawned")

                        End If

                    Case 199

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Monroe, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Monroe spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Monroe spawned")

                        End If

                    Case 200

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Monster, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Monster spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Monster spawned")

                        End If

                    Case 201

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Mower, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Mower spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Mower spawned")

                        End If

                    Case 202

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Mule, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Mule spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Mule spawned")

                        End If

                    Case 203

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Mule2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Mule 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Mule 2 spawned")

                        End If

                    Case 204

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Mule3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Mule 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Mule 3 spawned")

                        End If

                    Case 205

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Nemesis, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Nemesis spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Nemesis spawned")

                        End If

                    Case 206

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Ninef, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Ninef spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Ninef spawned")

                        End If

                    Case 207

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Ninef2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Ninef 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Ninef 2 spawned")

                        End If

                    Case 208

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Oracle, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Oracle spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Oracle spawned")

                        End If

                    Case 209

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Oracle2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Oracle 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Oracle 2 spawned")

                        End If

                    Case 210

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Osiris, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Osiris spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Osiris spawned")

                        End If

                    Case 211

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Packer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Packer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Packer spawned")

                        End If

                    Case 212

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Panto, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Panto spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Panto spawned")

                        End If

                    Case 213

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Paradise, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Paradise spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Paradise spawned")

                        End If

                    Case 214

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Patriot, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Patriot spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Patriot spawned")

                        End If

                    Case 215

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.PBus, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("P Bus spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("P Bus spawned")

                        End If

                    Case 216

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.PCJ, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("PCJ spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("PCJ spawned")

                        End If

                    Case 217

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Penumbra, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Penumbra spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Penumbra spawned")

                        End If

                    Case 218

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Peyote, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Peyote spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Peyote spawned")

                        End If

                    Case 219

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Phantom, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Phantom spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Phantom spawned")

                        End If

                    Case 220

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Phoenix, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Phoenix spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Phoenix spawned")

                        End If

                    Case 221

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Picador, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Picador spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Picador spawned")

                        End If

                    Case 222

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Pigalle, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Pigalle spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Pigalle spawned")

                        End If

                    Case 223

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Police, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Police spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Police spawned")

                        End If

                    Case 224

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Police2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Police 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Police 2 spawned")

                        End If

                    Case 225

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Police3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Police 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Police 3 spawned")

                        End If

                    Case 226

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Police4, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Police 4 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Police 4 spawned")

                        End If

                    Case 227

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Policeb, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Police B spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Police B spawned")

                        End If

                    Case 228

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.PoliceOld1, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Police Old spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Police Old spawned")

                        End If

                    Case 229

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.PoliceOld2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Police Old 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Police Old 2 spawned")

                        End If

                    Case 230

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.PoliceT, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Police T spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Police T spawned")

                        End If

                    Case 231

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Polmav, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Polmav spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Polmav spawned")

                        End If

                    Case 232

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Pony, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Pony spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Pony spawned")

                        End If

                    Case 233

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Pony2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Pony 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Pony 2 spawned")

                        End If

                    Case 234

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Pounder, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Pounder spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Pounder spawned")

                        End If

                    Case 235

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Prairie, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Prairie spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Prairie spawned")

                        End If

                    Case 236

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Pranger, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Pranger spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Pranger spawned")

                        End If

                    Case 237

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Predator, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Predator spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Predator spawned")

                        End If

                    Case 238

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Premier, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Premier spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Premier spawned")

                        End If

                    Case 239

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Primo, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Primo spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Primo spawned")

                        End If

                    Case 240

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.PropTrailer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Prop Trailer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Prop Trailer spawned")

                        End If

                    Case 241

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Radi, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Radi spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Radi spawned")

                        End If

                    Case 242

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.RakeTrailer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rake Trailer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rake Trailer spawned")

                        End If

                    Case 243

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.RancherXL, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rancher XL spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rancher XL spawned")

                        End If

                    Case 244

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.RancherXL2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rancher XL 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rancher XL 2 spawned")

                        End If

                    Case 245

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.RapidGT, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rapid GT spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rapid GT spawned")

                        End If

                    Case 246

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.RapidGT2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rapid GT 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rapid GT 2 spawned")

                        End If

                    Case 247

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.RatLoader, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rat Loader spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rat Loader spawned")

                        End If

                    Case 248

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.RatLoader2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rat Loader 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rat Loader 2 spawned")

                        End If

                    Case 249

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Rebel, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rebel spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rebel spawned")

                        End If

                    Case 250

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Rebel2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rebel 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rebel 2 spawned")

                        End If

                    Case 251

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Regina, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Regina spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Regina spawned")

                        End If

                    Case 252

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.RentalBus, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rental Bus spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rental Bus spawned")

                        End If

                    Case 253

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Rhapsody, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rhapsody spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rhapsody spawned")

                        End If

                    Case 254

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Rhino, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rhino spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rhino spawned")

                        End If

                    Case 255

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Riot, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Riot spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Riot spawned")

                        End If

                    Case 256

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Ripley, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Ripley spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Ripley spawned")

                        End If

                    Case 257

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Rocoto, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rocoto spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rocoto spawned")

                        End If

                    Case 258

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Romero, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Romero spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Romero spawned")

                        End If

                    Case 259

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Rubble, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rubble spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rubble spawned")

                        End If

                    Case 260

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Ruffian, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Ruffian spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Ruffian spawned")

                        End If

                    Case 261

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Ruiner, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Ruiner spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Ruiner spawned")

                        End If

                    Case 262

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Rumpo, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rumpo spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rumpo spawned")

                        End If

                    Case 263

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Rumpo2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Rumpo 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Rumpo 2 spawned")

                        End If

                    Case 264

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.SabreGT, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Sabre GT spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Sabre GT spawned")

                        End If

                    Case 265

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Sadler, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Sadler spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Sadler spawned")

                        End If

                    Case 266

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Sadler2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Sadler 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Sadler 2 spawned")

                        End If

                    Case 267

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Sanchez, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Sanchez spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Sanchez spawned")

                        End If

                    Case 268

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Sanchez2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Sanchez2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Sanchez2 spawned")

                        End If

                    Case 269

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Sandking, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Sandking spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Sandking spawned")

                        End If

                    Case 270

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Sandking2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Sandking 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Sandking 2 spawned")

                        End If

                    Case 271

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Savage, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Savage spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Savage spawned")

                        End If

                    Case 272

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Schafter2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Schafter spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Schafter spawned")

                        End If

                    Case 273

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Schwarzer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Schwarzer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Schwarzer spawned")

                        End If

                    Case 274

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Scorcher, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Scorcher spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Scorcher spawned")

                        End If

                    Case 275

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Scrap, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Scrap spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Scrap spawned")

                        End If

                    Case 276

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Seashark, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Sea Shark spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Sea Shark spawned")

                        End If

                    Case 277

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Seashark2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Sea Shark 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Sea Shark 2 spawned")

                        End If

                    Case 278

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Seminole, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Seminole spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Seminole spawned")

                        End If

                    Case 279

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Sentinel, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Sentinel spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Sentinel spawned")

                        End If

                    Case 280

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Sentinel2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Sentinel 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Sentinel 2 spawned")

                        End If

                    Case 281

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Serrano, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Serrano spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Serrano spawned")

                        End If

                    Case 282

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Shamal, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Shamal spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Shamal spawned")

                        End If

                    Case 283

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Sheriff, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Sheriff spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Sheriff spawned")

                        End If

                    Case 284

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Sheriff2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Sheriff 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Sheriff 2 spawned")

                        End If

                    Case 285

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Skylift, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Skylift spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Skylift spawned")

                        End If

                    Case 286

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Skylift, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Skylift 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Skylift 2 spawned")

                        End If

                    Case 287

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.SlamVan, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Slam Van spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Slam Van spawned")

                        End If

                    Case 288

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.SlamVan2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Slam Van 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Slam Van 2 spawned")

                        End If

                    Case 289

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Sovereign, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Sovereign spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Sovereign spawned")

                        End If

                    Case 290

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Speeder, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Speeder spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Speeder spawned")

                        End If

                    Case 291

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Speedo, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Speedo spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Speedo spawned")

                        End If

                    Case 292

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Speedo2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Speedo 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Speedo 2 spawned")

                        End If

                    Case 293

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Squalo, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Squalo spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Squalo spawned")

                        End If

                    Case 294

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Stalion, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Stalion spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Stalion spawned")

                        End If

                    Case 295

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Stalion2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Stalion 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Stalion 2 spawned")

                        End If

                    Case 296

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Stanier, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Stanier spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Stanier spawned")

                        End If

                    Case 297

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Stinger, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Stinger spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Stinger spawned")

                        End If

                    Case 298

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.StingerGT, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Stinger GT spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Stinger GT spawned")

                        End If

                    Case 299

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Stockade, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Stockade spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Stockade spawned")

                        End If

                    Case 300

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Stockade3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Stockade 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Stockade 2 spawned")

                        End If

                    Case 301

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Stratum, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Stratum spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Stratum spawned")

                        End If

                    Case 302

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Stretch, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Stretch spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Stretch spawned")

                        End If

                    Case 303

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Stunt, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Stunt spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Stunt spawned")

                        End If

                    Case 304

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Submersible, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Submersible spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Submersible spawned")

                        End If

                    Case 305

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Submersible2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Submersible 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Submersible 2 spawned")

                        End If

                    Case 306

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Sultan, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Sultan spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Sultan spawned")

                        End If

                    Case 307

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Suntrap, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Suntrap spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Suntrap spawned")

                        End If

                    Case 308

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Superd, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Super Diamond spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Super Diamond spawned")

                        End If

                    Case 309

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Surano, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Surano spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Surano spawned")

                        End If

                    Case 310

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Surfer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Surfer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Surfer spawned")

                        End If

                    Case 311

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Surfer2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Surfer 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Surfer 2 spawned")

                        End If

                    Case 312

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Surge, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Surge spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Surge spawned")

                        End If

                    Case 313

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Swift, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Swift spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Swift spawned")

                        End If

                    Case 314

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Swift2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Swift 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Swift 2 spawned")

                        End If

                    Case 315

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.T20, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("T 20 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("T 20 spawned")

                        End If

                    Case 316

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Taco, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Taco spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Taco spawned")

                        End If

                    Case 317

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Tailgater, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tailgater spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tailgater spawned")

                        End If

                    Case 318

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Tanker, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tanker spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tanker spawned")

                        End If

                    Case 319

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Tanker2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tanker 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tanker 2 spawned")

                        End If

                    Case 320

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TankerCar, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tanker Car spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tanker Car spawned")

                        End If

                    Case 321

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Taxi, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Taxi spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Taxi spawned")

                        End If

                    Case 322

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Technical, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Technical spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Technical spawned")

                        End If

                    Case 323

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Thrust, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Thrust spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Thrust spawned")

                        End If

                    Case 324

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TipTruck, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tip Truck spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tip Truck spawned")

                        End If

                    Case 325

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TipTruck2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tip Truck 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tip Truck 2 spawned")

                        End If

                    Case 326

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Titan, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Titan spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Titan spawned")

                        End If

                    Case 327

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Tornado, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tornado spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tornado spawned")

                        End If

                    Case 328

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Tornado2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tornado 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tornado 2 spawned")

                        End If

                    Case 329

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Tornado3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tornado 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tornado 3 spawned")

                        End If

                    Case 330

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Tornado4, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tornado 4 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tornado 4 spawned")

                        End If

                    Case 331

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Toro, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Toro spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Toro spawned")

                        End If

                    Case 332

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Tourbus, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tour Bus spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tour Bus spawned")

                        End If

                    Case 333

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TowTruck, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tow Truck spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tow Truck spawned")

                        End If

                    Case 334

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TowTruck2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tow Truck 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tow Truck 2 spawned")

                        End If

                    Case 335

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TR2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("TR spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("TR spawned")

                        End If

                    Case 336

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TR3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("TR 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("TR 2 spawned")

                        End If

                    Case 337

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TR4, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("TR 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("TR 3 spawned")

                        End If

                    Case 338

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TR4, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("TR 4 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("TR 4 spawned")

                        End If

                    Case 339

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Tractor, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tractor spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tractor spawned")

                        End If

                    Case 340

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Tractor2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tractor 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tractor 2 spawned")

                        End If

                    Case 341

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Tractor3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tractor 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tractor 3 spawned")

                        End If

                    Case 342

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TrailerLogs, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Trailer Logs spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Trailer Logs spawned")

                        End If

                    Case 343

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Trailers, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Trailers spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Trailers spawned")

                        End If

                    Case 344

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Trailers2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Trailers 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Trailers 2 spawned")

                        End If

                    Case 345

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Trailers3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Trailers 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Trailers 3 spawned")

                        End If

                    Case 346

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TrailerSmall, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Trailer Small spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Trailer Small spawned")

                        End If

                    Case 347

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Trash, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Trash spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Trash spawned")

                        End If

                    Case 348

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Trash2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Trash 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Trash 2 spawned")

                        End If

                    Case 349

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TRFlat, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("TR Flat spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("TR Flat spawned")

                        End If

                    Case 350

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TriBike, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tri Bike spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tri Bike spawned")

                        End If

                    Case 351

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TriBike2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tri Bike 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tri Bike 2 spawned")

                        End If

                    Case 352

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TriBike3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tri Bike 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tri Bike 3 spawned")

                        End If

                    Case 353

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Tropic, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Tropic spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Tropic spawned")

                        End If

                    Case 354

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Turismor, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Turismor spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Turismor spawned")

                        End If

                    Case 355

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.TVTrailer, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("TV Trailer spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("TV Trailer spawned")

                        End If

                    Case 356

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.UtilityTruck, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Utility Truck spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Utility Truck spawned")

                        End If

                    Case 357

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.UtilityTruck2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Utility Truck 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Utility Truck 2 spawned")

                        End If

                    Case 358

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.UtilityTruck3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Utility Truck 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Utility Truck 3 spawned")

                        End If

                    Case 359

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.UtilliTruck, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Utilli Truck spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Utilli Truck spawned")

                        End If

                    Case 360

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.UtilliTruck2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Utilli Truck 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Utilli Truck 2 spawned")

                        End If

                    Case 361

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.UtilliTruck3, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Utilli Truck 3 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Utilli Truck 3 spawned")

                        End If

                    Case 362

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Vacca, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Vacca spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Vacca spawned")

                        End If

                    Case 363

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Vader, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Vader spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Vader spawned")

                        End If

                    Case 364

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Valkyrie, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Valkyrie spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Valkyrie spawned")

                        End If

                    Case 365

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Velum, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Velum spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Velum spawned")

                        End If

                    Case 366

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Velum2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Velum 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Velum 2 spawned")

                        End If

                    Case 367

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Vestra, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Vestra spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Vestra spawned")

                        End If

                    Case 368

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Vigero, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Vigero spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Vigero spawned")

                        End If

                    Case 369

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Vindicator, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Vindicator spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Vindicator spawned")

                        End If

                    Case 370

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Virgo, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Virgo spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Virgo spawned")

                        End If

                    Case 371

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Voltic, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Voltic spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Voltic spawned")

                        End If

                    Case 372

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Voodoo2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Voodoo spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Voodoo spawned")

                        End If

                    Case 373

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Warrener, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Warrener spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Warrener spawned")

                        End If

                    Case 374

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Washington, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Washington spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Washington spawned")

                        End If

                    Case 375

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Windsor, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Windsor spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Windsor spawned")

                        End If

                    Case 376

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Youga, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Youga spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Youga spawned")

                        End If

                    Case 377

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Zentorno, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Zentorno spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Zentorno spawned")

                        End If

                    Case 378

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Zion, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Zion spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Zion spawned")

                        End If

                    Case 379

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Zion2, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Zion 2 spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Zion 2 spawned")

                        End If

                    Case 380

                        Dim vehicle As Vehicle = World.CreateVehicle(VehicleHash.Ztype, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 5.0F, Game.Player.Character.Heading + 90)

                        vehicle.CustomPrimaryColor = colVehiclePrimaryColor
                        vehicle.CustomSecondaryColor = colVehicleSecondaryColor
                        vehicle.PlaceOnGround()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Z Type spawned")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Z Type spawned")

                        End If

                End Select

            End If

        Catch ex As NullReferenceException

        End Try

        byteVehicleNum = -1

    End Sub

End Class
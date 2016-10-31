Imports GTA
Imports NativeUI
Imports System.Speech
Imports System.Windows.Forms
Imports System.Drawing

Public Class Main
    Inherits Script

    Friend Shared config As ScriptSettings = ScriptSettings.Load(Application.StartupPath & "\scripts\bvc\vc.ini")
    Friend Shared intro As ScriptSettings = ScriptSettings.Load(Application.StartupPath & "\scripts\bvc\in.ini")

    Friend Shared strKeyWord As String = config.GetValue("STRING", "command_keyword", "Grand Theft Auto")
    Friend Shared primColor As String = config.GetValue("STRING", "primary_veh_color", "White")
    Friend Shared scndColor As String = config.GetValue("STRING", "secondary_veh_color", "White")
    Friend Shared boolListening As Boolean
    Friend Shared boolSubtitle As Boolean
    Friend Shared boolVoice As Boolean
    Friend Shared inBoolHasBeenOpened As Boolean
    Friend Shared toggleMenu As Keys = config.GetValue("KEYS", "toggle_menu", Keys.F7)
    Friend Shared toggleListening As Keys = config.GetValue("KEYS", "toggle_listening", Keys.F8)

    Friend Shared boolBVCEnabled As Boolean = False
    Friend Shared boolHasBeenOpened As Boolean = False

    Friend Shared WithEvents reco As New Recognition.SpeechRecognitionEngine

    Friend Shared gram As New Recognition.SrgsGrammar.SrgsDocument

    Friend Shared grammarRule As New Recognition.SrgsGrammar.SrgsRule("command")

    '                                                                                                     below is player settings
    Friend Shared commandGrammarList As New Recognition.SrgsGrammar.SrgsOneOf(strKeyWord & ", add money",
                                                                        strKeyWord & ", give me a small loan",
                                                                        strKeyWord & ", wanted level up",
                                                                        strKeyWord & ", wanted level down",
                                                                        strKeyWord & ", wanted level max",
                                                                        strKeyWord & ", wanted level null",
                                                                        strKeyWord & ", toggle never wanted",
                                                                        strKeyWord & ", toggle invincibility",
                                                                        strKeyWord & ", toggle ignored by police",
                                                                        strKeyWord & ", toggle ignored by everyone", 'below is vehicle spawns
                                                                        strKeyWord & ", spawn vehicle Adder",
                                                                        strKeyWord & ", spawn vehicle Airbus",
                                                                        strKeyWord & ", spawn vehicle Airtug",
                                                                        strKeyWord & ", spawn vehicle Akuma",
                                                                        strKeyWord & ", spawn vehicle Alpha",
                                                                        strKeyWord & ", spawn vehicle Ambulance",
                                                                        strKeyWord & ", spawn vehicle Annihilator",
                                                                        strKeyWord & ", spawn vehicle Army Tanker",
                                                                        strKeyWord & ", spawn vehicle Army Trailer",
                                                                        strKeyWord & ", spawn vehicle Army Trailer 2",
                                                                        strKeyWord & ", spawn vehicle Asea",
                                                                        strKeyWord & ", spawn vehicle Asea 2",
                                                                        strKeyWord & ", spawn vehicle Asterope",
                                                                        strKeyWord & ", spawn vehicle Bagger",
                                                                        strKeyWord & ", spawn vehicle Bale Trailer",
                                                                        strKeyWord & ", spawn vehicle Baller",
                                                                        strKeyWord & ", spawn vehicle Baller 2",
                                                                        strKeyWord & ", spawn vehicle Banshee",
                                                                        strKeyWord & ", spawn vehicle Barracks",
                                                                        strKeyWord & ", spawn vehicle Barracks 2",
                                                                        strKeyWord & ", spawn vehicle Barracks 3",
                                                                        strKeyWord & ", spawn vehicle Bati",
                                                                        strKeyWord & ", spawn vehicle Bati 2",
                                                                        strKeyWord & ", spawn vehicle Benson",
                                                                        strKeyWord & ", spawn vehicle Besra",
                                                                        strKeyWord & ", spawn vehicle Bf Injection",
                                                                        strKeyWord & ", spawn vehicle Biff",
                                                                        strKeyWord & ", spawn vehicle Bifta",
                                                                        strKeyWord & ", spawn vehicle Bison",
                                                                        strKeyWord & ", spawn vehicle Bison 2",
                                                                        strKeyWord & ", spawn vehicle Bison 3",
                                                                        strKeyWord & ", spawn vehicle BJXL",
                                                                        strKeyWord & ", spawn vehicle Blade",
                                                                        strKeyWord & ", spawn vehicle Blazer",
                                                                        strKeyWord & ", spawn vehicle Blazer 2",
                                                                        strKeyWord & ", spawn vehicle Blazer 3",
                                                                        strKeyWord & ", spawn vehicle Blimp",
                                                                        strKeyWord & ", spawn vehicle Blimp 2",
                                                                        strKeyWord & ", spawn vehicle Blista",
                                                                        strKeyWord & ", spawn vehicle Blista 2",
                                                                        strKeyWord & ", spawn vehicle Blista 3",
                                                                        strKeyWord & ", spawn vehicle Bmx",
                                                                        strKeyWord & ", spawn vehicle Boat Trailer",
                                                                        strKeyWord & ", spawn vehicle Bobcat XL",
                                                                        strKeyWord & ", spawn vehicle Bodhi",
                                                                        strKeyWord & ", spawn vehicle Boxville",
                                                                        strKeyWord & ", spawn vehicle Boxville 2",
                                                                        strKeyWord & ", spawn vehicle Boxville 3",
                                                                        strKeyWord & ", spawn vehicle Boxville 4",
                                                                        strKeyWord & ", spawn vehicle Brawler",
                                                                        strKeyWord & ", spawn vehicle B Type",
                                                                        strKeyWord & ", spawn vehicle Buccaneer",
                                                                        strKeyWord & ", spawn vehicle Buffolo",
                                                                        strKeyWord & ", spawn vehicle Buffolo 2",
                                                                        strKeyWord & ", spawn vehicle Buffolo 3",
                                                                        strKeyWord & ", spawn vehicle Bulldozer",
                                                                        strKeyWord & ", spawn vehicle Bullet",
                                                                        strKeyWord & ", spawn vehicle Burrito",
                                                                        strKeyWord & ", spawn vehicle Burrito 2",
                                                                        strKeyWord & ", spawn vehicle Burrito 3",
                                                                        strKeyWord & ", spawn vehicle Burrito 4",
                                                                        strKeyWord & ", spawn vehicle Burrito 5",
                                                                        strKeyWord & ", spawn vehicle Bus",
                                                                        strKeyWord & ", spawn vehicle Buzzard",
                                                                        strKeyWord & ", spawn vehicle Buzzard 2",
                                                                        strKeyWord & ", spawn vehicle Cable Car",
                                                                        strKeyWord & ", spawn vehicle Caddy",
                                                                        strKeyWord & ", spawn vehicle Caddy 2",
                                                                        strKeyWord & ", spawn vehicle Camper",
                                                                        strKeyWord & ", spawn vehicle Carbonizzare",
                                                                        strKeyWord & ", spawn vehicle Carbon R5",
                                                                        strKeyWord & ", spawn vehicle Cargobob",
                                                                        strKeyWord & ", spawn vehicle Cargobob 2",
                                                                        strKeyWord & ", spawn vehicle Cargobob 3",
                                                                        strKeyWord & ", spawn vehicle Cargo Plane",
                                                                        strKeyWord & ", spawn vehicle Casco",
                                                                        strKeyWord & ", spawn vehicle Cavalcade",
                                                                        strKeyWord & ", spawn vehicle Cavalcade 2",
                                                                        strKeyWord & ", spawn vehicle Cheetah",
                                                                        strKeyWord & ", spawn vehicle Chino",
                                                                        strKeyWord & ", spawn vehicle Coach",
                                                                        strKeyWord & ", spawn vehicle Cognoscenti Cabrio",
                                                                        strKeyWord & ", spawn vehicle Comet",
                                                                        strKeyWord & ", spawn vehicle Coquette",
                                                                        strKeyWord & ", spawn vehicle Coquette 2",
                                                                        strKeyWord & ", spawn vehicle Coquette 3",
                                                                        strKeyWord & ", spawn vehicle Cruiser",
                                                                        strKeyWord & ", spawn vehicle Crusader",
                                                                        strKeyWord & ", spawn vehicle Cuban 800",
                                                                        strKeyWord & ", spawn vehicle Cutter",
                                                                        strKeyWord & ", spawn vehicle Daemon",
                                                                        strKeyWord & ", spawn vehicle Dilettante",
                                                                        strKeyWord & ", spawn vehicle Dilettante 2",
                                                                        strKeyWord & ", spawn vehicle Dinghy",
                                                                        strKeyWord & ", spawn vehicle Dinghy 2",
                                                                        strKeyWord & ", spawn vehicle Dinghy 3",
                                                                        strKeyWord & ", spawn vehicle D Loader",
                                                                        strKeyWord & ", spawn vehicle Dock Trailer",
                                                                        strKeyWord & ", spawn vehicle Dock Tug",
                                                                        strKeyWord & ", spawn vehicle Dodo",
                                                                        strKeyWord & ", spawn vehicle Dominator",
                                                                        strKeyWord & ", spawn vehicle Dominator 2",
                                                                        strKeyWord & ", spawn vehicle Double",
                                                                        strKeyWord & ", spawn vehicle Dubsta",
                                                                        strKeyWord & ", spawn vehicle Dubsta 2",
                                                                        strKeyWord & ", spawn vehicle Dubsta 3",
                                                                        strKeyWord & ", spawn vehicle Dukes",
                                                                        strKeyWord & ", spawn vehicle Dukes 2",
                                                                        strKeyWord & ", spawn vehicle Dump",
                                                                        strKeyWord & ", spawn vehicle Dune",
                                                                        strKeyWord & ", spawn vehicle Dune 2",
                                                                        strKeyWord & ", spawn vehicle Duster",
                                                                        strKeyWord & ", spawn vehicle Elegy",
                                                                        strKeyWord & ", spawn vehicle Emperor",
                                                                        strKeyWord & ", spawn vehicle Emperor 2",
                                                                        strKeyWord & ", spawn vehicle Emperor 3",
                                                                        strKeyWord & ", spawn vehicle Enduro",
                                                                        strKeyWord & ", spawn vehicle Entity XF",
                                                                        strKeyWord & ", spawn vehicle Exemplar",
                                                                        strKeyWord & ", spawn vehicle F 620",
                                                                        strKeyWord & ", spawn vehicle Faggio",
                                                                        strKeyWord & ", spawn vehicle FBI",
                                                                        strKeyWord & ", spawn vehicle FBI 2",
                                                                        strKeyWord & ", spawn vehicle Felon",
                                                                        strKeyWord & ", spawn vehicle Felon 2",
                                                                        strKeyWord & ", spawn vehicle Feltzer",
                                                                        strKeyWord & ", spawn vehicle Feltzer 2",
                                                                        strKeyWord & ", spawn vehicle Firetruck",
                                                                        strKeyWord & ", spawn vehicle Fixter",
                                                                        strKeyWord & ", spawn vehicle Flatbed",
                                                                        strKeyWord & ", spawn vehicle Forklift",
                                                                        strKeyWord & ", spawn vehicle Fq 2",
                                                                        strKeyWord & ", spawn vehicle Freight",
                                                                        strKeyWord & ", spawn vehicle Freight Car",
                                                                        strKeyWord & ", spawn vehicle Freight Container",
                                                                        strKeyWord & ", spawn vehicle Freight Container 2",
                                                                        strKeyWord & ", spawn vehicle Freight Grain",
                                                                        strKeyWord & ", spawn vehicle Freight Trailer",
                                                                        strKeyWord & ", spawn vehicle Frogger",
                                                                        strKeyWord & ", spawn vehicle Frogger 2",
                                                                        strKeyWord & ", spawn vehicle Fugitive",
                                                                        strKeyWord & ", spawn vehicle Furoregt",
                                                                        strKeyWord & ", spawn vehicle Fusilade",
                                                                        strKeyWord & ", spawn vehicle Futo",
                                                                        strKeyWord & ", spawn vehicle Gauntlet",
                                                                        strKeyWord & ", spawn vehicle Gauntlet 2",
                                                                        strKeyWord & ", spawn vehicle G Burrito",
                                                                        strKeyWord & ", spawn vehicle G Burrito 2",
                                                                        strKeyWord & ", spawn vehicle Glendale",
                                                                        strKeyWord & ", spawn vehicle Grain Trailer",
                                                                        strKeyWord & ", spawn vehicle Granger",
                                                                        strKeyWord & ", spawn vehicle Gresley",
                                                                        strKeyWord & ", spawn vehicle Guardian",
                                                                        strKeyWord & ", spawn vehicle Habanero",
                                                                        strKeyWord & ", spawn vehicle Hakuchou",
                                                                        strKeyWord & ", spawn vehicle Handler",
                                                                        strKeyWord & ", spawn vehicle Hauler",
                                                                        strKeyWord & ", spawn vehicle Hexer",
                                                                        strKeyWord & ", spawn vehicle Hotknife",
                                                                        strKeyWord & ", spawn vehicle Huntley",
                                                                        strKeyWord & ", spawn vehicle Hydra",
                                                                        strKeyWord & ", spawn vehicle Infernus",
                                                                        strKeyWord & ", spawn vehicle Ingot",
                                                                        strKeyWord & ", spawn vehicle Innovation",
                                                                        strKeyWord & ", spawn vehicle Insurgent",
                                                                        strKeyWord & ", spawn vehicle Insurgent 2",
                                                                        strKeyWord & ", spawn vehicle Intruder",
                                                                        strKeyWord & ", spawn vehicle Issi 2",
                                                                        strKeyWord & ", spawn vehicle Jackal",
                                                                        strKeyWord & ", spawn vehicle JB 700",
                                                                        strKeyWord & ", spawn vehicle Jester",
                                                                        strKeyWord & ", spawn vehicle Jester 2",
                                                                        strKeyWord & ", spawn vehicle Jet",
                                                                        strKeyWord & ", spawn vehicle Jetmax",
                                                                        strKeyWord & ", spawn vehicle Journey",
                                                                        strKeyWord & ", spawn vehicle Kalahari",
                                                                        strKeyWord & ", spawn vehicle Khamelion",
                                                                        strKeyWord & ", spawn vehicle Kuruma",
                                                                        strKeyWord & ", spawn vehicle Kuruma 2",
                                                                        strKeyWord & ", spawn vehicle Land Stalker",
                                                                        strKeyWord & ", spawn vehicle Laser",
                                                                        strKeyWord & ", spawn vehicle Lectro",
                                                                        strKeyWord & ", spawn vehicle L Guard",
                                                                        strKeyWord & ", spawn vehicle Luxor",
                                                                        strKeyWord & ", spawn vehicle Luxor 2",
                                                                        strKeyWord & ", spawn vehicle Mammatus",
                                                                        strKeyWord & ", spawn vehicle Manana",
                                                                        strKeyWord & ", spawn vehicle Marquis",
                                                                        strKeyWord & ", spawn vehicle Marshall",
                                                                        strKeyWord & ", spawn vehicle Massacro",
                                                                        strKeyWord & ", spawn vehicle Massacro 2",
                                                                        strKeyWord & ", spawn vehicle Maverick",
                                                                        strKeyWord & ", spawn vehicle Mesa",
                                                                        strKeyWord & ", spawn vehicle Mesa 2",
                                                                        strKeyWord & ", spawn vehicle Mesa 3",
                                                                        strKeyWord & ", spawn vehicle Miljet",
                                                                        strKeyWord & ", spawn vehicle Minivan",
                                                                        strKeyWord & ", spawn vehicle Mixer",
                                                                        strKeyWord & ", spawn vehicle Mixer 2",
                                                                        strKeyWord & ", spawn vehicle Monroe",
                                                                        strKeyWord & ", spawn vehicle Monster",
                                                                        strKeyWord & ", spawn vehicle Mower",
                                                                        strKeyWord & ", spawn vehicle Mule",
                                                                        strKeyWord & ", spawn vehicle Mule 2",
                                                                        strKeyWord & ", spawn vehicle Mule 3",
                                                                        strKeyWord & ", spawn vehicle Nemesis",
                                                                        strKeyWord & ", spawn vehicle Ninef",
                                                                        strKeyWord & ", spawn vehicle Ninef 2",
                                                                        strKeyWord & ", spawn vehicle Oracle",
                                                                        strKeyWord & ", spawn vehicle Oracle 2",
                                                                        strKeyWord & ", spawn vehicle Osiris",
                                                                        strKeyWord & ", spawn vehicle Packer",
                                                                        strKeyWord & ", spawn vehicle Panto",
                                                                        strKeyWord & ", spawn vehicle Paradise",
                                                                        strKeyWord & ", spawn vehicle Patriot",
                                                                        strKeyWord & ", spawn vehicle P Bus",
                                                                        strKeyWord & ", spawn vehicle PCJ",
                                                                        strKeyWord & ", spawn vehicle Penumbra",
                                                                        strKeyWord & ", spawn vehicle Peyote",
                                                                        strKeyWord & ", spawn vehicle Phantom",
                                                                        strKeyWord & ", spawn vehicle Phoenix",
                                                                        strKeyWord & ", spawn vehicle Picador",
                                                                        strKeyWord & ", spawn vehicle Pigalle",
                                                                        strKeyWord & ", spawn vehicle Police",
                                                                        strKeyWord & ", spawn vehicle Police 2",
                                                                        strKeyWord & ", spawn vehicle Police 3",
                                                                        strKeyWord & ", spawn vehicle Police 4",
                                                                        strKeyWord & ", spawn vehicle Police B",
                                                                        strKeyWord & ", spawn vehicle Police Old",
                                                                        strKeyWord & ", spawn vehicle Police Old 2",
                                                                        strKeyWord & ", spawn vehicle Police T",
                                                                        strKeyWord & ", spawn vehicle Polmav",
                                                                        strKeyWord & ", spawn vehicle Pony",
                                                                        strKeyWord & ", spawn vehicle Pony 2",
                                                                        strKeyWord & ", spawn vehicle Pounder",
                                                                        strKeyWord & ", spawn vehicle Prairie",
                                                                        strKeyWord & ", spawn vehicle Pranger",
                                                                        strKeyWord & ", spawn vehicle Predator",
                                                                        strKeyWord & ", spawn vehicle Premier",
                                                                        strKeyWord & ", spawn vehicle Primo",
                                                                        strKeyWord & ", spawn vehicle Prop Trailer",
                                                                        strKeyWord & ", spawn vehicle Radi",
                                                                        strKeyWord & ", spawn vehicle Rake Trailer",
                                                                        strKeyWord & ", spawn vehicle Rancher XL",
                                                                        strKeyWord & ", spawn vehicle Rancher XL 2",
                                                                        strKeyWord & ", spawn vehicle Rapid GT",
                                                                        strKeyWord & ", spawn vehicle Rapid GT 2",
                                                                        strKeyWord & ", spawn vehicle Rat Loader",
                                                                        strKeyWord & ", spawn vehicle Rat Loader 2",
                                                                        strKeyWord & ", spawn vehicle Rebel",
                                                                        strKeyWord & ", spawn vehicle Rebel 2",
                                                                        strKeyWord & ", spawn vehicle Regina",
                                                                        strKeyWord & ", spawn vehicle Rental Bus",
                                                                        strKeyWord & ", spawn vehicle Rhapsody",
                                                                        strKeyWord & ", spawn vehicle Rhino",
                                                                        strKeyWord & ", spawn vehicle Riot",
                                                                        strKeyWord & ", spawn vehicle Ripley",
                                                                        strKeyWord & ", spawn vehicle Rocoto",
                                                                        strKeyWord & ", spawn vehicle Romero",
                                                                        strKeyWord & ", spawn vehicle Rubble",
                                                                        strKeyWord & ", spawn vehicle Ruffian",
                                                                        strKeyWord & ", spawn vehicle Ruiner",
                                                                        strKeyWord & ", spawn vehicle Rumpo",
                                                                        strKeyWord & ", spawn vehicle Rumpo 2",
                                                                        strKeyWord & ", spawn vehicle Sabre GT",
                                                                        strKeyWord & ", spawn vehicle Sadler",
                                                                        strKeyWord & ", spawn vehicle Sadler 2",
                                                                        strKeyWord & ", spawn vehicle Sanchez",
                                                                        strKeyWord & ", spawn vehicle Sanchez 2",
                                                                        strKeyWord & ", spawn vehicle Sandking",
                                                                        strKeyWord & ", spawn vehicle Sandking 2",
                                                                        strKeyWord & ", spawn vehicle Savage",
                                                                        strKeyWord & ", spawn vehicle Schafter",
                                                                        strKeyWord & ", spawn vehicle Schwarzer",
                                                                        strKeyWord & ", spawn vehicle Scorcher",
                                                                        strKeyWord & ", spawn vehicle Scrap",
                                                                        strKeyWord & ", spawn vehicle Sea Shark",
                                                                        strKeyWord & ", spawn vehicle Sea Shark 2",
                                                                        strKeyWord & ", spawn vehicle Seminole",
                                                                        strKeyWord & ", spawn vehicle Sentinal",
                                                                        strKeyWord & ", spawn vehicle Sentinal 2",
                                                                        strKeyWord & ", spawn vehicle Serrano",
                                                                        strKeyWord & ", spawn vehicle Shamal",
                                                                        strKeyWord & ", spawn vehicle Sheriff",
                                                                        strKeyWord & ", spawn vehicle Sheriff 2",
                                                                        strKeyWord & ", spawn vehicle Skylift",
                                                                        strKeyWord & ", spawn vehicle Skylift 2",
                                                                        strKeyWord & ", spawn vehicle Slam Van",
                                                                        strKeyWord & ", spawn vehicle Slam Van 2",
                                                                        strKeyWord & ", spawn vehicle Sovereign",
                                                                        strKeyWord & ", spawn vehicle Speeder",
                                                                        strKeyWord & ", spawn vehicle Speedo",
                                                                        strKeyWord & ", spawn vehicle Speedo 2",
                                                                        strKeyWord & ", spawn vehicle Squalo",
                                                                        strKeyWord & ", spawn vehicle Stalion",
                                                                        strKeyWord & ", spawn vehicle Stalion 2",
                                                                        strKeyWord & ", spawn vehicle Stanier",
                                                                        strKeyWord & ", spawn vehicle Stinger",
                                                                        strKeyWord & ", spawn vehicle Stinger GT",
                                                                        strKeyWord & ", spawn vehicle Stockade",
                                                                        strKeyWord & ", spawn vehicle Stockade 2",
                                                                        strKeyWord & ", spawn vehicle Stratum",
                                                                        strKeyWord & ", spawn vehicle Stretch",
                                                                        strKeyWord & ", spawn vehicle Stunt",
                                                                        strKeyWord & ", spawn vehicle Submersible",
                                                                        strKeyWord & ", spawn vehicle Submersible 2",
                                                                        strKeyWord & ", spawn vehicle Sultan",
                                                                        strKeyWord & ", spawn vehicle Suntrap",
                                                                        strKeyWord & ", spawn vehicle Super Diamond",
                                                                        strKeyWord & ", spawn vehicle Surano",
                                                                        strKeyWord & ", spawn vehicle Surfer",
                                                                        strKeyWord & ", spawn vehicle Surfer 2",
                                                                        strKeyWord & ", spawn vehicle Surge",
                                                                        strKeyWord & ", spawn vehicle Swift",
                                                                        strKeyWord & ", spawn vehicle Swift 2",
                                                                        strKeyWord & ", spawn vehicle T 20",
                                                                        strKeyWord & ", spawn vehicle Taco",
                                                                        strKeyWord & ", spawn vehicle Tailgater",
                                                                        strKeyWord & ", spawn vehicle Tanker",
                                                                        strKeyWord & ", spawn vehicle Tanker 2",
                                                                        strKeyWord & ", spawn vehicle Tanker Car",
                                                                        strKeyWord & ", spawn vehicle Taxi",
                                                                        strKeyWord & ", spawn vehicle Technical",
                                                                        strKeyWord & ", spawn vehicle Thrust",
                                                                        strKeyWord & ", spawn vehicle Tip Truck",
                                                                        strKeyWord & ", spawn vehicle Tip Truck 2",
                                                                        strKeyWord & ", spawn vehicle Titan",
                                                                        strKeyWord & ", spawn vehicle Tornado",
                                                                        strKeyWord & ", spawn vehicle Tornado 2",
                                                                        strKeyWord & ", spawn vehicle Tornado 3",
                                                                        strKeyWord & ", spawn vehicle Tornado 4",
                                                                        strKeyWord & ", spawn vehicle Toro",
                                                                        strKeyWord & ", spawn vehicle Tour Bus",
                                                                        strKeyWord & ", spawn vehicle Tow Truck",
                                                                        strKeyWord & ", spawn vehicle Tow Truck 2",
                                                                        strKeyWord & ", spawn vehicle TR",
                                                                        strKeyWord & ", spawn vehicle TR 2",
                                                                        strKeyWord & ", spawn vehicle TR 3",
                                                                        strKeyWord & ", spawn vehicle TR 4",
                                                                        strKeyWord & ", spawn vehicle Tractor",
                                                                        strKeyWord & ", spawn vehicle Tractor 2",
                                                                        strKeyWord & ", spawn vehicle Tractor 3",
                                                                        strKeyWord & ", spawn vehicle Trailer Logs",
                                                                        strKeyWord & ", spawn vehicle Trailers",
                                                                        strKeyWord & ", spawn vehicle Trailers 2",
                                                                        strKeyWord & ", spawn vehicle Trailers 3",
                                                                        strKeyWord & ", spawn vehicle Trailer Small",
                                                                        strKeyWord & ", spawn vehicle Trash",
                                                                        strKeyWord & ", spawn vehicle Trash 2",
                                                                        strKeyWord & ", spawn vehicle TR Flat",
                                                                        strKeyWord & ", spawn vehicle Tri Bike",
                                                                        strKeyWord & ", spawn vehicle Tri Bike 2",
                                                                        strKeyWord & ", spawn vehicle Tri Bike 3",
                                                                        strKeyWord & ", spawn vehicle Tropic",
                                                                        strKeyWord & ", spawn vehicle Turismor",
                                                                        strKeyWord & ", spawn vehicle TV Trailer",
                                                                        strKeyWord & ", spawn vehicle Utility Truck",
                                                                        strKeyWord & ", spawn vehicle Utility Truck 2",
                                                                        strKeyWord & ", spawn vehicle Utility Truck 3",
                                                                        strKeyWord & ", spawn vehicle Utilli Truck",
                                                                        strKeyWord & ", spawn vehicle Utilli Truck 2",
                                                                        strKeyWord & ", spawn vehicle Utilli Truck 3",
                                                                        strKeyWord & ", spawn vehicle Vacca",
                                                                        strKeyWord & ", spawn vehicle Vader",
                                                                        strKeyWord & ", spawn vehicle Valkyrie",
                                                                        strKeyWord & ", spawn vehicle Velum",
                                                                        strKeyWord & ", spawn vehicle Velum 2",
                                                                        strKeyWord & ", spawn vehicle Vestra",
                                                                        strKeyWord & ", spawn vehicle Vigero",
                                                                        strKeyWord & ", spawn vehicle Vindicator",
                                                                        strKeyWord & ", spawn vehicle Virgo",
                                                                        strKeyWord & ", spawn vehicle Voltic",
                                                                        strKeyWord & ", spawn vehicle Voodoo",
                                                                        strKeyWord & ", spawn vehicle Warrener",
                                                                        strKeyWord & ", spawn vehicle Washington",
                                                                        strKeyWord & ", spawn vehicle Windsor",
                                                                        strKeyWord & ", spawn vehicle Youga",
                                                                        strKeyWord & ", spawn vehicle Zentorno",
                                                                        strKeyWord & ", spawn vehicle Zion",
                                                                        strKeyWord & ", spawn vehicle Zion 2",
                                                                        strKeyWord & ", spawn vehicle Z Type",
                                                                        strKeyWord & ", spawn vehicle random",'below is vehicle settings
                                                                        strKeyWord & ", repair vehicle",
                                                                        strKeyWord & ", toggle vehicle invincibility",
                                                                        strKeyWord & ", toggle vehicle strong wheels", 'below is world settings
                                                                        strKeyWord & ", set weather extra sunny", '0
                                                                        strKeyWord & ", set weather clear", '1
                                                                        strKeyWord & ", set weather cloudy", '2
                                                                        strKeyWord & ", set weather smog", '3
                                                                        strKeyWord & ", set weather foggy", '4
                                                                        strKeyWord & ", set weather overcast", '5
                                                                        strKeyWord & ", set weather rain", '6
                                                                        strKeyWord & ", set weather thunderstorm", '7
                                                                        strKeyWord & ", set weather clearing", '8
                                                                        strKeyWord & ", set weather neutral", '9
                                                                        strKeyWord & ", set weather snow", '10
                                                                        strKeyWord & ", set weather blizzard", '11
                                                                        strKeyWord & ", set weather snowlight", '12
                                                                        strKeyWord & ", add time one hour", '0
                                                                        strKeyWord & ", subtract time one hour", '1
                                                                        strKeyWord & ", set time morning", '2
                                                                        strKeyWord & ", set time mid day", '3
                                                                        strKeyWord & ", set time evening", '4
                                                                        strKeyWord & ", set time midnight", '5
                                                                        strKeyWord & ", toggle time pause",
                                                                        strKeyWord & ", time system sync", 'below is player settings
                                                                        strKeyWord & ", add weapon all", '0
                                                                        strKeyWord & ", add weapon advanced rifle",
                                                                        strKeyWord & ", add weapon assault rifle",
                                                                        strKeyWord & ", add weapon assault shotgun",
                                                                        strKeyWord & ", add weapon assault smg",
                                                                        strKeyWord & ", add weapon bat",
                                                                        strKeyWord & ", add weapon carbon rifle",
                                                                        strKeyWord & ", add weapon combat pistol",
                                                                        strKeyWord & ", add weapon crowbar",
                                                                        strKeyWord & ", add weapon dagger",
                                                                        strKeyWord & ", add weapon fire extinguisher",
                                                                        strKeyWord & ", add weapon firework launcher",
                                                                        strKeyWord & ", add weapon golf club",
                                                                        strKeyWord & ", add weapon grenade",
                                                                        strKeyWord & ", add weapon grenade launcher",
                                                                        strKeyWord & ", add weapon hammer",
                                                                        strKeyWord & ", add weapon hatchet",
                                                                        strKeyWord & ", add weapon heavy pistol",
                                                                        strKeyWord & ", add weapon heavy shotgun",
                                                                        strKeyWord & ", add weapon heavy sniper",
                                                                        strKeyWord & ", add weapon homing launcher",
                                                                        strKeyWord & ", add weapon knife",
                                                                        strKeyWord & ", add weapon marksman pistol",
                                                                        strKeyWord & ", add weapon marksman rifle",
                                                                        strKeyWord & ", add weapon micro smg",
                                                                        strKeyWord & ", add weapon mini gun",
                                                                        strKeyWord & ", add weapon molotov",
                                                                        strKeyWord & ", add weapon musket",
                                                                        strKeyWord & ", add weapon night stick",
                                                                        strKeyWord & ", add weapon pistol",
                                                                        strKeyWord & ", add weapon fifty cal",
                                                                        strKeyWord & ", add weapon proximity mine",
                                                                        strKeyWord & ", add weapon pump shotgun",
                                                                        strKeyWord & ", add weapon rail gun",
                                                                        strKeyWord & ", add weapon rpg",
                                                                        strKeyWord & ", add weapon sawn off shotgun",
                                                                        strKeyWord & ", add weapon smg",
                                                                        strKeyWord & ", add weapon smoke grenade",
                                                                        strKeyWord & ", add weapon sniper rifle",
                                                                        strKeyWord & ", add weapon snowball",
                                                                        strKeyWord & ", add weapon sns pistol",
                                                                        strKeyWord & ", add weapon special carbine",
                                                                        strKeyWord & ", add weapon sticky bomb",
                                                                        strKeyWord & ", add weapon stun gun",
                                                                        strKeyWord & ", add weapon vintage pistol")

    Friend Shared synth As New Synthesis.SpeechSynthesizer

    Friend Shared boolSettingChangedSubtitle As Boolean = True
    Friend Shared boolSettingChangedSpeak As Boolean = True

    Dim WithEvents voiceMenu As New UIMenu("GTA Voice Commands", "By: Blake Boris")
    Dim WithEvents voiceMenuPool As New MenuPool()

    Dim btnListening As UIMenuCheckboxItem
    Dim btnCSub As UIMenuCheckboxItem
    Dim btnCVoice As UIMenuCheckboxItem

    Dim gameListPrimColors As UIMenuListItem
    Dim gameListScndColors As UIMenuListItem

    Dim allWeapons As New List(Of Object) From {"Advanced Rifle",
                                                                        "Assault Rifle",
                                                                        "Assault Shotgun",
                                                                        "Assault SMG",
                                                                        "Bat",
                                                                        "Carbon Rifle",
                                                                        "Combat Pistol",
                                                                        "Crowbar",
                                                                        "Dagger",
                                                                        "Fire Extinguisher",
                                                                        "Firework Launcher",
                                                                        "Golf Club",
                                                                        "Grenade",
                                                                        "Grenade Launcher",
                                                                        "Hammer",
                                                                        "Hatchet",
                                                                        "Heavy Pistol",
                                                                        "Heavy Shotgun",
                                                                        "Heavy Sniper",
                                                                        "Homing Launcher",
                                                                        "Knife",
                                                                        "Marksman Pistol",
                                                                        "Marksman Rifle",
                                                                        "Micro SMG",
                                                                        "Mini Gun",
                                                                        "Molotov",
                                                                        "Musket",
                                                                        "Night Stick",
                                                                        "Pistol",
                                                                        "Fifty Cal",
                                                                        "Proximity Mine",
                                                                        "Pump Shotgun",
                                                                        "Rail Gun",
                                                                        "RPG",
                                                                        "Sawn Off Shotgun",
                                                                        "SMG",
                                                                        "Smoke Grenade",
                                                                        "Sniper Rifle",
                                                                        "Snowball",
                                                                        "SNS Pistol",
                                                                        "Special Carbine",
                                                                        "Sticky Bomb",
                                                                        "Stun Gun",
                                                                        "Vintage Pistol"}

    Dim allVehicles As New List(Of Object) From {"Adder",
                                                                        "Airbus",
                                                                        "Airtug",
                                                                        "Akuma",
                                                                        "Alpha",
                                                                        "Ambulance",
                                                                        "Annihilator",
                                                                        "Army Tanker",
                                                                        "Army Trailer",
                                                                        "Army Trailer 2",
                                                                        "Asea",
                                                                        "Asea 2",
                                                                        "Asterope",
                                                                        "Bagger",
                                                                        "Bale Trailer",
                                                                        "Baller",
                                                                        "Baller 2",
                                                                        "Banshee",
                                                                        "Barracks",
                                                                        "Barracks 2",
                                                                        "Barracks 3",
                                                                        "Bati",
                                                                        "Bati 2",
                                                                        "Benson",
                                                                        "Besra",
                                                                        "Bf Injection",
                                                                        "Biff",
                                                                        "Bifta",
                                                                        "Bison",
                                                                        "Bison 2",
                                                                        "Bison 3",
                                                                        "BJXL",
                                                                        "Blade",
                                                                        "Blazer",
                                                                        "Blazer 2",
                                                                        "Blazer 3",
                                                                        "Blimp",
                                                                        "Blimp 2",
                                                                        "Blista",
                                                                        "Blista 2",
                                                                        "Blista 3",
                                                                        "Bmx",
                                                                        "Boat Trailer",
                                                                        "Bobcat XL",
                                                                        "Bodhi",
                                                                        "Boxville",
                                                                        "Boxville 2",
                                                                        "Boxville 3",
                                                                        "Boxville 4",
                                                                        "Brawler",
                                                                        "B Type",
                                                                        "Buccaneer",
                                                                        "Buffolo",
                                                                        "Buffolo 2",
                                                                        "Buffolo 3",
                                                                        "Bulldozer",
                                                                        "Bullet",
                                                                        "Burrito",
                                                                        "Burrito 2",
                                                                        "Burrito 3",
                                                                        "Burrito 4",
                                                                        "Burrito 5",
                                                                        "Bus",
                                                                        "Buzzard",
                                                                        "Buzzard 2",
                                                                        "Cable Car",
                                                                        "Caddy",
                                                                        "Caddy 2",
                                                                        "Camper",
                                                                        "Carbonizzare",
                                                                        "Carbon R5",
                                                                        "Cargobob",
                                                                        "Cargobob 2",
                                                                        "Cargobob 3",
                                                                        "Cargo Plane",
                                                                        "Casco",
                                                                        "Cavalcade",
                                                                        "Cavalcade 2",
                                                                        "Cheetah",
                                                                        "Chino",
                                                                        "Coach",
                                                                        "Cognoscenti Cabrio",
                                                                        "Comet",
                                                                        "Coquette",
                                                                        "Coquette 2",
                                                                        "Coquette 3",
                                                                        "Cruiser",
                                                                        "Crusader",
                                                                        "Cuban 800",
                                                                        "Cutter",
                                                                        "Daemon",
                                                                        "Dilettante",
                                                                        "Dilettante 2",
                                                                        "Dinghy",
                                                                        "Dinghy 2",
                                                                        "Dinghy 3",
                                                                        "D Loader",
                                                                        "Dock Trailer",
                                                                        "Dock Tug",
                                                                        "Dodo",
                                                                        "Dominator",
                                                                        "Dominator 2",
                                                                        "Double",
                                                                        "Dubsta",
                                                                        "Dubsta 2",
                                                                        "Dubsta 3",
                                                                        "Dukes",
                                                                        "Dukes 2",
                                                                        "Dump",
                                                                        "Dune",
                                                                        "Dune 2",
                                                                        "Duster",
                                                                        "Elegy",
                                                                        "Emperor",
                                                                        "Emperor 2",
                                                                        "Emperor 3",
                                                                        "Enduro",
                                                                        "Entity XF",
                                                                        "Exemplar",
                                                                        "F 620",
                                                                        "Faggio",
                                                                        "FBI",
                                                                        "FBI 2",
                                                                        "Felon",
                                                                        "Felon 2",
                                                                        "Feltzer",
                                                                        "Feltzer 2",
                                                                        "Firetruck",
                                                                        "Fixter",
                                                                        "Flatbed",
                                                                        "Forklift",
                                                                        "Fq 2",
                                                                        "Freight",
                                                                        "Freight Car",
                                                                        "Freight Container",
                                                                        "Freight Container 2",
                                                                        "Freight Grain",
                                                                        "Freight Trailer",
                                                                        "Frogger",
                                                                        "Frogger 2",
                                                                        "Fugitive",
                                                                        "Furoregt",
                                                                        "Fusilade",
                                                                        "Futo",
                                                                        "Gauntlet",
                                                                        "Gauntlet 2",
                                                                        "G Burrito",
                                                                        "G Burrito 2",
                                                                        "Glendale",
                                                                        "Grain Trailer",
                                                                        "Granger",
                                                                        "Gresley",
                                                                        "Guardian",
                                                                        "Habanero",
                                                                        "Hakuchou",
                                                                        "Handler",
                                                                        "Hauler",
                                                                        "Hexer",
                                                                        "Hotknife",
                                                                        "Huntley",
                                                                        "Hydra",
                                                                        "Infernus",
                                                                        "Ingot",
                                                                        "Innovation",
                                                                        "Insurgent",
                                                                        "Insurgent 2",
                                                                        "Intruder",
                                                                        "Issi 2",
                                                                        "Jackal",
                                                                        "JB 700",
                                                                        "Jester",
                                                                        "Jester 2",
                                                                        "Jet",
                                                                        "Jetmax",
                                                                        "Journey",
                                                                        "Kalahari",
                                                                        "Khamelion",
                                                                        "Kuruma",
                                                                        "Kuruma 2",
                                                                        "Land Stalker",
                                                                        "Laser",
                                                                        "Lectro",
                                                                        "L Guard",
                                                                        "Luxor",
                                                                        "Luxor 2",
                                                                        "Mammatus",
                                                                        "Manana",
                                                                        "Marquis",
                                                                        "Marshall",
                                                                        "Massacro",
                                                                        "Massacro 2",
                                                                        "Maverick",
                                                                        "Mesa",
                                                                        "Mesa 2",
                                                                        "Mesa 3",
                                                                        "Miljet",
                                                                        "Minivan",
                                                                        "Mixer",
                                                                        "Mixer 2",
                                                                        "Monroe",
                                                                        "Monster",
                                                                        "Mower",
                                                                        "Mule",
                                                                        "Mule 2",
                                                                        "Mule 3",
                                                                        "Nemesis",
                                                                        "Ninef",
                                                                        "Ninef 2",
                                                                        "Oracle",
                                                                        "Oracle 2",
                                                                        "Osiris",
                                                                        "Packer",
                                                                        "Panto",
                                                                        "Paradise",
                                                                        "Patriot",
                                                                        "P Bus",
                                                                        "PCJ",
                                                                        "Penumbra",
                                                                        "Peyote",
                                                                        "Phantom",
                                                                        "Phoenix",
                                                                        "Picador",
                                                                        "Pigalle",
                                                                        "Police",
                                                                        "Police 2",
                                                                        "Police 3",
                                                                        "Police 4",
                                                                        "Police B",
                                                                        "Police Old",
                                                                        "Police Old 2",
                                                                        "Police T",
                                                                        "Polmav",
                                                                        "Pony",
                                                                        "Pony 2",
                                                                        "Pounder",
                                                                        "Prairie",
                                                                        "Pranger",
                                                                        "Predator",
                                                                        "Premier",
                                                                        "Primo",
                                                                        "Prop Trailer",
                                                                        "Radi",
                                                                        "Rake Trailer",
                                                                        "Rancher XL",
                                                                        "Rancher XL 2",
                                                                        "Rapid GT",
                                                                        "Rapid GT 2",
                                                                        "Rat Loader",
                                                                        "Rat Loader 2",
                                                                        "Rebel",
                                                                        "Rebel 2",
                                                                        "Regina",
                                                                        "Rental Bus",
                                                                        "Rhapsody",
                                                                        "Rhino",
                                                                        "Riot",
                                                                        "Ripley",
                                                                        "Rocoto",
                                                                        "Romero",
                                                                        "Rubble",
                                                                        "Ruffian",
                                                                        "Ruiner",
                                                                        "Rumpo",
                                                                        "Rumpo 2",
                                                                        "Sabre GT",
                                                                        "Sadler",
                                                                        "Sadler 2",
                                                                        "Sanchez",
                                                                        "Sanchez 2",
                                                                        "Sandking",
                                                                        "Sandking 2",
                                                                        "Savage",
                                                                        "Schafter",
                                                                        "Schwarzer",
                                                                        "Scorcher",
                                                                        "Scrap",
                                                                        "Sea Shark",
                                                                        "Sea Shark 2",
                                                                        "Seminole",
                                                                        "Sentinal",
                                                                        "Sentinal 2",
                                                                        "Serrano",
                                                                        "Shamal",
                                                                        "Sheriff",
                                                                        "Sheriff 2",
                                                                        "Skylift",
                                                                        "Skylift 2",
                                                                        "Slam Van",
                                                                        "Slam Van 2",
                                                                        "Sovereign",
                                                                        "Speeder",
                                                                        "Speedo",
                                                                        "Speedo 2",
                                                                        "Squalo",
                                                                        "Stalion",
                                                                        "Stalion 2",
                                                                        "Stanier",
                                                                        "Stinger",
                                                                        "Stinger GT",
                                                                        "Stockade",
                                                                        "Stockade 2",
                                                                        "Stratum",
                                                                        "Stretch",
                                                                        "Stunt",
                                                                        "Submersible",
                                                                        "Submersible 2",
                                                                        "Sultan",
                                                                        "Suntrap",
                                                                        "Super Diamond",
                                                                        "Surano",
                                                                        "Surfer",
                                                                        "Surfer 2",
                                                                        "Surge",
                                                                        "Swift",
                                                                        "Swift 2",
                                                                        "T 20",
                                                                        "Taco",
                                                                        "Tailgater",
                                                                        "Tanker",
                                                                        "Tanker 2",
                                                                        "Tanker Car",
                                                                        "Taxi",
                                                                        "Technical",
                                                                        "Thrust",
                                                                        "Tip Truck",
                                                                        "Tip Truck 2",
                                                                        "Titan",
                                                                        "Tornado",
                                                                        "Tornado 2",
                                                                        "Tornado 3",
                                                                        "Tornado 4",
                                                                        "Toro",
                                                                        "Tour Bus",
                                                                        "Tow Truck",
                                                                        "Tow Truck 2",
                                                                        "TR",
                                                                        "TR 2",
                                                                        "TR 3",
                                                                        "TR 4",
                                                                        "Tractor",
                                                                        "Tractor 2",
                                                                        "Tractor 3",
                                                                        "Trailer Logs",
                                                                        "Trailers",
                                                                        "Trailers 2",
                                                                        "Trailers 3",
                                                                        "Trailer Small",
                                                                        "Trash",
                                                                        "Trash 2",
                                                                        "TR Flat",
                                                                        "Tri Bike",
                                                                        "Tri Bike 2",
                                                                        "Tri Bike 3",
                                                                        "Tropic",
                                                                        "Turismor",
                                                                        "TV Trailer",
                                                                        "Utility Truck",
                                                                        "Utility Truck 2",
                                                                        "Utility Truck 3",
                                                                        "Utilli Truck",
                                                                        "Utilli Truck 2",
                                                                        "Utilli Truck 3",
                                                                        "Vacca",
                                                                        "Vader",
                                                                        "Valkyrie",
                                                                        "Velum",
                                                                        "Velum 2",
                                                                        "Vestra",
                                                                        "Vigero",
                                                                        "Vindicator",
                                                                        "Virgo",
                                                                        "Voltic",
                                                                        "Voodoo",
                                                                        "Warrener",
                                                                        "Washington",
                                                                        "Windsor",
                                                                        "Youga",
                                                                        "Zentorno",
                                                                        "Zion",
                                                                        "Zion 2",
                                                                        "Z Type"}

    Dim listPrimColors As New List(Of Object) From {"White", "Black", "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Pink"}
    Dim listScndColors As New List(Of Object) From {"White", "Black", "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Pink"}

    Dim cfg As String = Application.StartupPath & "\scripts\bvc\vc.ini"

    Public Sub New()

        Interval = 1

        reco.SetInputToDefaultAudioDevice()
        grammarRule.Add(commandGrammarList)
        gram.Rules.Add(grammarRule)
        gram.Root = grammarRule
        reco.LoadGrammar(New Recognition.Grammar(gram))
        reco.RecognizeAsync()

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("BOOL_LISTENING = True") <> -1 Then

            boolBVCEnabled = True

        Else

            boolBVCEnabled = False

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("BOOL_SUBTITLE = True") <> -1 Then

            boolSettingChangedSubtitle = True

        Else

            boolSettingChangedSubtitle = False

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("BOOL_VOICE = True") <> -1 Then

            boolSettingChangedSpeak = True

        Else

            boolSettingChangedSpeak = False

        End If

        btnListening = New UIMenuCheckboxItem("Listening:", boolBVCEnabled, "This toggles the main listening mechanic of the mod.                                                                                                                                  [SETTING WILL SAVE AFTER A RESTART]")
        btnCSub = New UIMenuCheckboxItem("Command to Subtitle:", boolSettingChangedSubtitle, "This toggles whether or not subtitles appear when a command is called.                                                                                                            [SETTING WILL SAVE AFTER A RESTART]")
        btnCVoice = New UIMenuCheckboxItem("Command to Voice:", boolSettingChangedSpeak, "This toggles whether or not a funny voice plays when a command is called.                                                                                                       (This voice is changeable in control panel)                                                                                [SETTING WILL SAVE AFTER A RESTART]")

        boolListening = config.GetValue("BOOL", "bool_listening", boolBVCEnabled)
        boolSubtitle = config.GetValue("BOOL", "bool_subtitle", boolSettingChangedSubtitle)
        boolVoice = config.GetValue("BOOL", "bool_voice", boolSettingChangedSpeak)
        inBoolHasBeenOpened = intro.GetValue("BOOL", "has_been_opened", boolHasBeenOpened)

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("PRIMARY_VEH_COLOR = White") <> -1 Then

            SpawnVehicles.intVehiclePrimaryColorType = 0
            SpawnVehicles.boolShowVehiclePrimaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("PRIMARY_VEH_COLOR = Black") <> -1 Then

            SpawnVehicles.intVehiclePrimaryColorType = 1
            SpawnVehicles.boolShowVehiclePrimaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("PRIMARY_VEH_COLOR = Red") <> -1 Then

            SpawnVehicles.intVehiclePrimaryColorType = 2
            SpawnVehicles.boolShowVehiclePrimaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("PRIMARY_VEH_COLOR = Orange") <> -1 Then

            SpawnVehicles.intVehiclePrimaryColorType = 3
            SpawnVehicles.boolShowVehiclePrimaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("PRIMARY_VEH_COLOR = Yellow") <> -1 Then

            SpawnVehicles.intVehiclePrimaryColorType = 4
            SpawnVehicles.boolShowVehiclePrimaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("PRIMARY_VEH_COLOR = Green") <> -1 Then

            SpawnVehicles.intVehiclePrimaryColorType = 5
            SpawnVehicles.boolShowVehiclePrimaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("PRIMARY_VEH_COLOR = Blue") <> -1 Then

            SpawnVehicles.intVehiclePrimaryColorType = 6
            SpawnVehicles.boolShowVehiclePrimaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("PRIMARY_VEH_COLOR = Purple") <> -1 Then

            SpawnVehicles.intVehiclePrimaryColorType = 7
            SpawnVehicles.boolShowVehiclePrimaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("PRIMARY_VEH_COLOR = Pink") <> -1 Then

            SpawnVehicles.intVehiclePrimaryColorType = 8
            SpawnVehicles.boolShowVehiclePrimaryColor = True

        End If



        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("SECONDARY_VEH_COLOR = White") <> -1 Then

            SpawnVehicles.intVehicleSecondaryColorType = 0
            SpawnVehicles.boolShowVehicleSecondaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("SECONDARY_VEH_COLOR = Black") <> -1 Then

            SpawnVehicles.intVehicleSecondaryColorType = 1
            SpawnVehicles.boolShowVehicleSecondaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("SECONDARY_VEH_COLOR = Red") <> -1 Then

            SpawnVehicles.intVehicleSecondaryColorType = 2
            SpawnVehicles.boolShowVehicleSecondaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("SECONDARY_VEH_COLOR = Orange") <> -1 Then

            SpawnVehicles.intVehicleSecondaryColorType = 3
            SpawnVehicles.boolShowVehicleSecondaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("SECONDARY_VEH_COLOR = Yellow") <> -1 Then

            SpawnVehicles.intVehicleSecondaryColorType = 4
            SpawnVehicles.boolShowVehicleSecondaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("SECONDARY_VEH_COLOR = Green") <> -1 Then

            SpawnVehicles.intVehicleSecondaryColorType = 5
            SpawnVehicles.boolShowVehicleSecondaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("SECONDARY_VEH_COLOR = Blue") <> -1 Then

            SpawnVehicles.intVehicleSecondaryColorType = 6
            SpawnVehicles.boolShowVehicleSecondaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("SECONDARY_VEH_COLOR = Purple") <> -1 Then

            SpawnVehicles.intVehicleSecondaryColorType = 7
            SpawnVehicles.boolShowVehicleSecondaryColor = True

        End If

        If My.Computer.FileSystem.ReadAllText(cfg).IndexOf("SECONDARY_VEH_COLOR = Pink") <> -1 Then

            SpawnVehicles.intVehicleSecondaryColorType = 8
            SpawnVehicles.boolShowVehicleSecondaryColor = True

        End If

        If inBoolHasBeenOpened = False And strKeyWord <> "Grand Theft Auto" And toggleMenu <> 118 Then

            synth.SpeakAsync("Thank you for downloading Blake Boris's GTA 5 Voice Commands Mod. Normally you should be able to press the F7 key to open the mod's menu, but it seems as though you're a wizard or a witch because it has been changed. 
                            After opening the mod menu with your key, you can edit all but one setting in the mod, the keyword, this is Grand Theft Auto by default, but it seems as though you've used your powers again because it has been changed to " & strKeyWord &
                            ". I think you've got this under control. A full list of commands can be found in the read me file that came with the mod. Thank's again for downloading and do have a fantastic day.")

            inBoolHasBeenOpened = True
            My.Computer.FileSystem.WriteAllText((Application.StartupPath & "\scripts\bvc\in.ini"), My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\scripts\bvc\in.ini").Replace("HAS_BEEN_OPENED = False", "HAS_BEEN_OPENED = True"), False)

        End If

        If inBoolHasBeenOpened = False And strKeyWord <> "Grand Theft Auto" And toggleMenu = 118 Then

            synth.SpeakAsync("Thank you for downloading Blake Boris's GTA 5 Voice Commands Mod. You should be able to press the F7 key to open the mod's menu. 
                            From there, you can edit all but one setting in the mod, the keyword, this is Grand Theft Auto by default, but it seems as though you're a wizard or a witch because it has been changed to " & strKeyWord &
                            ". A full list of commands can be found in the read me file that came with the mod. Thank's again for downloading and do have a fantastic day.")

            inBoolHasBeenOpened = True
            My.Computer.FileSystem.WriteAllText((Application.StartupPath & "\scripts\bvc\in.ini"), My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\scripts\bvc\in.ini").Replace("HAS_BEEN_OPENED = False", "HAS_BEEN_OPENED = True"), False)

        End If

        If inBoolHasBeenOpened = False And strKeyWord = "Grand Theft Auto" And toggleMenu <> 118 Then

            synth.SpeakAsync("Thank you for downloading Blake Boris's GTA 5 Voice Commands Mod. Normally you should be able to press the F7 key to open the mod's menu, but it seems as though you're a wizard or a witch because it has been changed. 
                            After opening the mod menu with your key, you can edit all but one setting in the mod, the keyword, this is Grand Theft Auto by default.
                            A full list of commands can be found in the read me file that came with the mod. Thank's again for downloading and do have a fantastic day.")

            inBoolHasBeenOpened = True
            My.Computer.FileSystem.WriteAllText((Application.StartupPath & "\scripts\bvc\in.ini"), My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\scripts\bvc\in.ini").Replace("HAS_BEEN_OPENED = False", "HAS_BEEN_OPENED = True"), False)

        End If

        If inBoolHasBeenOpened = False And strKeyWord = "Grand Theft Auto" And toggleMenu = 118 Then

            synth.SpeakAsync("Thank you for downloading Blake Boris's GTA 5 Voice Commands Mod. You should be able to press the F7 key to open the mod's menu. 
                            From there, you can edit all but one setting in the mod, the keyword, this is Grand Theft Auto by default.
                            You can change it in the V C initialization file that should be in your bvc folder that came with the mod.
                            A full list of commands can be found in the read me file. Thank's again for downloading and do have a fantastic day.")

            inBoolHasBeenOpened = True
            My.Computer.FileSystem.WriteAllText((Application.StartupPath & "\scripts\bvc\in.ini"), My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\scripts\bvc\in.ini").Replace("HAS_BEEN_OPENED = False", "HAS_BEEN_OPENED = True"), False)

        End If

        gameListPrimColors = New UIMenuListItem("Primary Color:", listPrimColors, SpawnVehicles.intVehiclePrimaryColorType, "This list houses the primary colors you can choose to spawn your vehicles.                                                                                                       [SETTING WILL SAVE AFTER A RESTART]")
        gameListScndColors = New UIMenuListItem("Secondary Color:", listScndColors, SpawnVehicles.intVehicleSecondaryColorType, "This list houses the secondary colors you can choose to spawn your vehicles.                                                                                                 [SETTING WILL SAVE AFTER A RESTART]")

        voiceMenu.SetMenuWidthOffset(80)

        Dim banner As New UIResRectangle()
        banner.Color = Color.FromArgb(255, 0, 170, 50)
        voiceMenu.SetBannerType(banner)

        voiceMenu.AddItem(btnListening)
        voiceMenu.AddItem(btnCSub)
        voiceMenu.AddItem(btnCVoice)
        voiceMenu.AddItem(New UIMenuListItem("Weapons:", allWeapons, 0, "This list houses every weapon you can spawn. If you want all of them at once use the command 'Add Weapon All'                                                                                                                         (An easier to read list of the weapons can be found in the README file)"))
        voiceMenu.AddItem(New UIMenuListItem("Vehicles:", allVehicles, 0, "This list houses every vehicle you can spawn.                                                                            (An easier to read list of the vehicles can be found in the README file)"))
        voiceMenu.AddItem(gameListPrimColors)
        voiceMenu.AddItem(gameListScndColors)

        voiceMenu.RefreshIndex()
        voiceMenuPool.Add(voiceMenu)

    End Sub

    Public Sub ListChangeEvent(ByVal Menu As UIMenu, ByVal Sender As UIMenuListItem, ByVal newindex As Integer) Handles voiceMenu.OnListChange

        If gameListPrimColors.Selected = True Then

            If gameListPrimColors.Index = 0 Then

                SpawnVehicles.intVehiclePrimaryColorType = 0
                SpawnVehicles.boolShowVehiclePrimaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = White", "PRIMARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Black", "PRIMARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Red", "PRIMARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Orange", "PRIMARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Yellow", "PRIMARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Green", "PRIMARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Blue", "PRIMARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Purple", "PRIMARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Pink", "PRIMARY_VEH_COLOR = White"), False)

            End If

            If gameListPrimColors.Index = 1 Then

                SpawnVehicles.intVehiclePrimaryColorType = 1
                SpawnVehicles.boolShowVehiclePrimaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = White", "PRIMARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Black", "PRIMARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Red", "PRIMARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Orange", "PRIMARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Yellow", "PRIMARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Green", "PRIMARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Blue", "PRIMARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Purple", "PRIMARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Pink", "PRIMARY_VEH_COLOR = Black"), False)

            End If

            If gameListPrimColors.Index = 2 Then

                SpawnVehicles.intVehiclePrimaryColorType = 2
                SpawnVehicles.boolShowVehiclePrimaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = White", "PRIMARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Black", "PRIMARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Red", "PRIMARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Orange", "PRIMARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Yellow", "PRIMARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Green", "PRIMARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Blue", "PRIMARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Purple", "PRIMARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Pink", "PRIMARY_VEH_COLOR = Red"), False)

            End If

            If gameListPrimColors.Index = 3 Then

                SpawnVehicles.intVehiclePrimaryColorType = 3
                SpawnVehicles.boolShowVehiclePrimaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = White", "PRIMARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Black", "PRIMARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Red", "PRIMARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Orange", "PRIMARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Yellow", "PRIMARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Green", "PRIMARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Blue", "PRIMARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Purple", "PRIMARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Pink", "PRIMARY_VEH_COLOR = Orange"), False)

            End If

            If gameListPrimColors.Index = 4 Then

                SpawnVehicles.intVehiclePrimaryColorType = 4
                SpawnVehicles.boolShowVehiclePrimaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = White", "PRIMARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Black", "PRIMARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Red", "PRIMARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Orange", "PRIMARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Yellow", "PRIMARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Green", "PRIMARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Blue", "PRIMARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Purple", "PRIMARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Pink", "PRIMARY_VEH_COLOR = Yellow"), False)

            End If

            If gameListPrimColors.Index = 5 Then

                SpawnVehicles.intVehiclePrimaryColorType = 5
                SpawnVehicles.boolShowVehiclePrimaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = White", "PRIMARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Black", "PRIMARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Red", "PRIMARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Orange", "PRIMARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Yellow", "PRIMARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Green", "PRIMARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Blue", "PRIMARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Purple", "PRIMARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Pink", "PRIMARY_VEH_COLOR = Green"), False)

            End If

            If gameListPrimColors.Index = 6 Then

                SpawnVehicles.intVehiclePrimaryColorType = 6
                SpawnVehicles.boolShowVehiclePrimaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = White", "PRIMARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Black", "PRIMARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Red", "PRIMARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Orange", "PRIMARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Yellow", "PRIMARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Green", "PRIMARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Blue", "PRIMARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Purple", "PRIMARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Pink", "PRIMARY_VEH_COLOR = Blue"), False)

            End If

            If gameListPrimColors.Index = 7 Then

                SpawnVehicles.intVehiclePrimaryColorType = 7
                SpawnVehicles.boolShowVehiclePrimaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = White", "PRIMARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Black", "PRIMARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Red", "PRIMARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Orange", "PRIMARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Yellow", "PRIMARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Green", "PRIMARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Blue", "PRIMARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Purple", "PRIMARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Pink", "PRIMARY_VEH_COLOR = Purple"), False)

            End If

            If gameListPrimColors.Index = 8 Then

                SpawnVehicles.intVehiclePrimaryColorType = 8
                SpawnVehicles.boolShowVehiclePrimaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = White", "PRIMARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Black", "PRIMARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Red", "PRIMARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Orange", "PRIMARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Yellow", "PRIMARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Green", "PRIMARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Blue", "PRIMARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Purple", "PRIMARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("PRIMARY_VEH_COLOR = Pink", "PRIMARY_VEH_COLOR = Pink"), False)

            End If

        End If

        If gameListScndColors.Selected = True Then

            If gameListScndColors.Index = 0 Then

                SpawnVehicles.intVehicleSecondaryColorType = 0
                SpawnVehicles.boolShowVehicleSecondaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = White", "SECONDARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Black", "SECONDARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Red", "SECONDARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Orange", "SECONDARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Yellow", "SECONDARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Green", "SECONDARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Blue", "SECONDARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Purple", "SECONDARY_VEH_COLOR = White"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Pink", "SECONDARY_VEH_COLOR = White"), False)

            End If

            If gameListScndColors.Index = 1 Then

                SpawnVehicles.intVehicleSecondaryColorType = 1
                SpawnVehicles.boolShowVehicleSecondaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = White", "SECONDARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Black", "SECONDARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Red", "SECONDARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Orange", "SECONDARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Yellow", "SECONDARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Green", "SECONDARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Blue", "SECONDARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Purple", "SECONDARY_VEH_COLOR = Black"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Pink", "SECONDARY_VEH_COLOR = Black"), False)

            End If

            If gameListScndColors.Index = 2 Then

                SpawnVehicles.intVehicleSecondaryColorType = 2
                SpawnVehicles.boolShowVehicleSecondaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = White", "SECONDARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Black", "SECONDARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Red", "SECONDARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Orange", "SECONDARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Yellow", "SECONDARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Green", "SECONDARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Blue", "SECONDARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Purple", "SECONDARY_VEH_COLOR = Red"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Pink", "SECONDARY_VEH_COLOR = Red"), False)

            End If

            If gameListScndColors.Index = 3 Then

                SpawnVehicles.intVehicleSecondaryColorType = 3
                SpawnVehicles.boolShowVehicleSecondaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = White", "SECONDARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Black", "SECONDARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Red", "SECONDARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Orange", "SECONDARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Yellow", "SECONDARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Green", "SECONDARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Blue", "SECONDARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Purple", "SECONDARY_VEH_COLOR = Orange"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Pink", "SECONDARY_VEH_COLOR = Orange"), False)

            End If

            If gameListScndColors.Index = 4 Then

                SpawnVehicles.intVehicleSecondaryColorType = 4
                SpawnVehicles.boolShowVehicleSecondaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = White", "SECONDARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Black", "SECONDARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Red", "SECONDARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Orange", "SECONDARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Yellow", "SECONDARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Green", "SECONDARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Blue", "SECONDARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Purple", "SECONDARY_VEH_COLOR = Yellow"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Pink", "SECONDARY_VEH_COLOR = Yellow"), False)

            End If

            If gameListScndColors.Index = 5 Then

                SpawnVehicles.intVehicleSecondaryColorType = 5
                SpawnVehicles.boolShowVehicleSecondaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = White", "SECONDARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Black", "SECONDARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Red", "SECONDARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Orange", "SECONDARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Yellow", "SECONDARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Green", "SECONDARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Blue", "SECONDARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Purple", "SECONDARY_VEH_COLOR = Green"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Pink", "SECONDARY_VEH_COLOR = Green"), False)

            End If

            If gameListScndColors.Index = 6 Then

                SpawnVehicles.intVehicleSecondaryColorType = 6
                SpawnVehicles.boolShowVehicleSecondaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = White", "SECONDARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Black", "SECONDARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Red", "SECONDARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Orange", "SECONDARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Yellow", "SECONDARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Green", "SECONDARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Blue", "SECONDARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Purple", "SECONDARY_VEH_COLOR = Blue"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Pink", "SECONDARY_VEH_COLOR = Blue"), False)

            End If

            If gameListScndColors.Index = 7 Then

                SpawnVehicles.intVehicleSecondaryColorType = 7
                SpawnVehicles.boolShowVehicleSecondaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = White", "SECONDARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Black", "SECONDARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Red", "SECONDARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Orange", "SECONDARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Yellow", "SECONDARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Green", "SECONDARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Blue", "SECONDARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Purple", "SECONDARY_VEH_COLOR = Purple"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Pink", "SECONDARY_VEH_COLOR = Purple"), False)

            End If

            If gameListScndColors.Index = 8 Then

                SpawnVehicles.intVehicleSecondaryColorType = 8
                SpawnVehicles.boolShowVehicleSecondaryColor = True

                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = White", "SECONDARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Black", "SECONDARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Red", "SECONDARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Orange", "SECONDARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Yellow", "SECONDARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Green", "SECONDARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Blue", "SECONDARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Purple", "SECONDARY_VEH_COLOR = Pink"), False)
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("SECONDARY_VEH_COLOR = Pink", "SECONDARY_VEH_COLOR = Pink"), False)

            End If

        End If

    End Sub

    Public Sub CheckboxEvent(ByVal Menu As UIMenu, ByVal Sender As UIMenuCheckboxItem, ByVal Checked As Boolean) Handles voiceMenu.OnCheckboxChange

        If btnListening.Selected = True Then

            If boolListening = True Then

                If boolSettingChangedSubtitle = True Then

                    UI.ShowSubtitle("Voice Commands: Disabled")

                End If

                If boolSettingChangedSpeak = True Then

                    synth.SpeakAsync("Voice Commands: Disabled")

                End If

                boolBVCEnabled = False
                boolListening = False
                btnListening.Checked = False
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("BOOL_LISTENING = True", "BOOL_LISTENING = False"), False)

            ElseIf boolListening = False

                If boolSettingChangedSubtitle = True Then

                    UI.ShowSubtitle("Voice Commands: Enabled")

                End If

                If boolSettingChangedSpeak = True Then

                    synth.SpeakAsync("Voice Commands: Enabled")

                End If

                boolBVCEnabled = True
                boolListening = True
                btnListening.Checked = True
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("BOOL_LISTENING = False", "BOOL_LISTENING = True"), False)

            End If

        End If

        If btnCSub.Selected = True Then

            If boolSubtitle = True Then

                UI.ShowSubtitle("Subtitles: Disabled (This is the last one you'll see for now)")

                If boolSettingChangedSpeak = True Then

                    synth.SpeakAsync("Subtitles: Disabled")

                End If

                boolSettingChangedSubtitle = False
                boolSubtitle = False
                btnCSub.Checked = False
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("BOOL_SUBTITLE = True", "BOOL_SUBTITLE = False"), False)

            ElseIf boolSubtitle = False

                UI.ShowSubtitle("Subtitles: Enabled")

                If boolSettingChangedSpeak = True Then

                    synth.SpeakAsync("Subtitles: Enabled")

                End If

                boolSettingChangedSubtitle = True
                boolSubtitle = True
                btnCSub.Checked = True
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("BOOL_SUBTITLE = False", "BOOL_SUBTITLE = True"), False)

            End If

        End If

        If btnCVoice.Selected = True Then

            If boolVoice = True Then

                If boolSettingChangedSubtitle = True Then

                    UI.ShowSubtitle("Voice: Disabled")

                End If

                synth.SpeakAsync("Voice: Disabled (This is the last one you'll hear for now)")

                boolSettingChangedSpeak = False
                boolVoice = False
                btnCVoice.Checked = False
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("BOOL_VOICE = True", "BOOL_VOICE = False"), False)

            ElseIf boolVoice = False

                If boolSettingChangedSubtitle = True Then

                    UI.ShowSubtitle("Voice: Enabled")

                End If

                synth.SpeakAsync("Voice: Enabled")

                boolSettingChangedSpeak = True
                boolVoice = True
                btnCVoice.Checked = True
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("BOOL_VOICE = False", "BOOL_VOICE = True"), False)

            End If

        End If

    End Sub

    Public Sub Update(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Tick

        voiceMenuPool.ProcessMenus()

    End Sub

    'the sub below is in SpawnVehicles.vb because shared withevents variables such as reco cannot be called in the class they were created in.

    'Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As Recognition.RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted

    '    reco.RecognizeAsync()

    'End Sub

    Private Sub OnKeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

        If e.KeyCode = toggleMenu Then

            If voiceMenu.Visible = True Then

                voiceMenu.Visible = False

            ElseIf voiceMenu.Visible = False Then

                voiceMenu.Visible = True

            End If

        End If

        If e.KeyCode = toggleListening Then

            If boolBVCEnabled = True Then

                If boolSettingChangedSubtitle = True Then

                    UI.ShowSubtitle("Voice Commands: Disabled")

                End If

                If boolSettingChangedSpeak = True Then

                    synth.SpeakAsync("Voice Commands: Disabled")

                End If

                boolBVCEnabled = False
                btnListening.Checked = False
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("BOOL_LISTENING = True", "BOOL_LISTENING = False"), False)

            ElseIf boolBVCEnabled = False Then

                If boolSettingChangedSubtitle = True Then

                    UI.ShowSubtitle("Voice Commands: Enabled")

                End If

                If boolSettingChangedSpeak = True Then

                    synth.SpeakAsync("Voice Commands: Enabled")

                End If

                boolBVCEnabled = True
                btnListening.Checked = True
                My.Computer.FileSystem.WriteAllText(cfg, My.Computer.FileSystem.ReadAllText(cfg).Replace("BOOL_LISTENING = False", "BOOL_LISTENING = True"), False)

            End If

        End If

    End Sub

End Class
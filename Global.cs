namespace Project;

class Global
{
    public static Stanza[][] map = new Stanza[][]{};

    public static void Inizializza(Giocatore player)
    {
        // ====================================================================
        // 1. MAPPE CON CARATTERI FILLER (PUNTINI STELLARI) PER BLOCCARE L'ALLINEAMENTO
        // ====================================================================

        string mapSComandi = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../         >SEI QUI<         \
        +---------╳-------------+───────╱───────+─────────╱────+---------+
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +---------+─────────────┼───────────────┼─────────────+---------+
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────+─────────────┼───────╱───────┼─────────────+-────────+
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapCNord = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────────────┼───────╱───────┼─────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   >SEI QUI<   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +---------+─────────────┼───────────────┼─────────────+---------+
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapCSud = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |         |             |               |             |         |
        |  -   -  ╱─────────────   -   -   -   ╱─────────────  -   -  |
        |         |             |               |             |         |
        |  OVEST  | SALA MEDICA |   CENTRALE    |SALA OSSIGENO|   EST   |
        |         |             |               |             |         |
        +-────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| >SEI QUI<    | CORRIDOIO     |SALA OSSIGENO|CORRIDOIO|
        |  OVEST  | SALA MEDICA  | CENTRALE      |             |   EST   |
        |  SUD    |              | SUD           |             |  SUD    |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapONord = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |>SEI QUI<| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        |CORRIDOIO|             |   CENTRALE    |             |   EST   |
        | OVEST   |             |   NORD        |             |  NORD   |
        |  NORD   |             |               |             |         |
        +-────────┼─────────────┼───────────────┼─────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| SALA MEDICA | CORRIDOIO     |SALA OSSIGENO|CORRIDOIO|
        | OVEST   |             | CENTRALE      |             |   EST   |
        |  SUD    |             | SUD           |             |  SUD    |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapOSud = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        | OVEST   |             |   CENTRALE    |             |   EST   |
        |  NORD   |             |   NORD        |             |  NORD   |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────────────┼─────────────┤
        |         |             |               |             |         |
        |>SEI QUI<| SALA MEDICA | CORRIDOIO     |SALA OSSIGENO|CORRIDOIO|
        |CORRIDOIO|             | CENTRALE      |             |   EST   |
        | OVEST   |             | SUD           |             |  SUD    |
        |  SUD    |             |               |             |         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapENord = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |>SEI QUI<|
        | OVEST   |             |   CENTRALE    |             |CORRIDOIO|
        |  NORD   |             |   NORD        |             |  EST    |
        |         |             |               |             |  NORD   |
        +-────────┼─────────────┼───────────────┼─────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| SALA MEDICA | CORRIDOIO     |SALA OSSIGENO|CORRIDOIO|
        | OVEST   |             | CENTRALE      |             |   EST   |
        |  SUD    |             | SUD           |             |  SUD    |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapESud = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        | OVEST   |             |   CENTRALE    |             |   EST   |
        |  NORD   |             |   NORD        |             |  NORD   |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────────────┼─────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| SALA MEDICA | CORRIDOIO     |SALA OSSIGENO|>SEI QUI<|
        | OVEST   |             | CENTRALE      |             |CORRIDOIO|
        |  SUD    |             | SUD           |             |  EST    |
        |         |             |               |             |  SUD    |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapRipostiglio = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO|  >SEI QUI<  |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        | OVEST   | RIPOSTIGLIO |   CENTRALE    |             |   EST   |
        |  NORD   |             |   NORD        |             |  NORD   |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────────────┼─────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| SALA MEDICA | CORRIDOIO     |SALA OSSIGENO|CORRIDOIO|
        | OVEST   |             | CENTRALE      |             |   EST   |
        |  SUD    |             | SUD           |             |  SUD    |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapMedica = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        | OVEST   |             |   CENTRALE    |             |   EST   |
        |  NORD   |             |   NORD        |             |  NORD   |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────────────┼─────────────┤
        |         |             |               |             |         |
        |CORRIDOIO|  >SEI QUI<  | CORRIDOIO     |SALA OSSIGENO|CORRIDOIO|
        | OVEST   | SALA MEDICA | CENTRALE      |             |   EST   |
        |  SUD    |             | SUD           |             |  SUD    |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapArchivio = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  >SEI QUI<  |CORRIDOIO|
        | OVEST   |             |   CENTRALE    |  ARCHIVIO   |   EST   |
        |  NORD   |             |   NORD        |             |  NORD   |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────────────┼─────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| SALA MEDICA | CORRIDOIO     |SALA OSSIGENO|CORRIDOIO|
        | OVEST   |             | CENTRALE      |             |   EST   |
        |  SUD    |             | SUD           |             |  SUD    |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapOssigeno = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        | OVEST   |             |   CENTRALE    |             |   EST   |
        |  NORD   |             |   NORD        |             |  NORD   |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────────────┼─────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| SALA MEDICA | CORRIDOIO     | >SEI QUI<   |CORRIDOIO|
        | OVEST   |             | CENTRALE      | SALA        |   EST   |
        |  SUD    |             | SUD           | OSSIGENO    |  SUD    |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST 2   |               |    EST 1    :  EST 2  |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapMotoriO1 = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        | OVEST   |             |   CENTRALE    |             |   EST   |
        |  NORD   |             |   NORD        |             |  NORD   |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────────────┼─────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| SALA MEDICA | CORRIDOIO     |SALA OSSIGENO|CORRIDOIO|
        | OVEST   |             | CENTRALE      |             |   EST   |
        |  SUD    |             | SUD           |             |  SUD    |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        |         :             |               |             :         |
        |>SEI QUI<:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | S.MOT.  :   OVEST     |               |    EST      :  EST    |
        | OVEST 1 :   EST       |               |    OVEST    :  EST    |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapMotoriO2 = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        | OVEST   |             |   CENTRALE    |             |   EST   |
        |  NORD   |             |   NORD        |             |  NORD   |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────────────┼─────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| SALA MEDICA | CORRIDOIO     |SALA OSSIGENO|CORRIDOIO|
        | OVEST   |             | CENTRALE      |             |   EST   |
        |  SUD    |             | SUD           |             |  SUD    |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  >SEI QUI<  |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   S.MOTORI  |               |    EST      :  EST    |
        |         :   OVEST     |               |    OVEST    :  EST    |
        |         :   EST       |               |             :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapMagazzino = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        | OVEST   |             |   CENTRALE    |             |   EST   |
        |  NORD   |             |   NORD        |             |  NORD   |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────────────┼─────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| SALA MEDICA | CORRIDOIO     |SALA OSSIGENO|CORRIDOIO|
        | OVEST   |             | CENTRALE      |             |   EST   |
        |  SUD    |             | SUD           |             |  SUD    |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   >SEI QUI<   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST     |   MAGAZZINO   |    EST      :  EST    |
        |         :   EST       |               |    OVEST    :  EST    |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapMotoriE1 = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        | OVEST   |             |   CENTRALE    |             |   EST   |
        |  NORD   |             |   NORD        |             |  NORD   |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────────────┼─────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| SALA MEDICA | CORRIDOIO     |SALA OSSIGENO|CORRIDOIO|
        | OVEST   |             | CENTRALE      |             |   EST   |
        |  SUD    |             | SUD           |             |  SUD    |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  >SEI QUI<  : S.MOTORI|
        | OVEST 1 :   OVEST     |               |    S.MOT.   :  EST    |
        |         :   EST       |               |    EST      :  EST    |
        |         :             |               |    OVEST    :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapMotoriE2 = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        | OVEST   |             |   CENTRALE    |             |   EST   |
        |  NORD   |             |   NORD        |             |  NORD   |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────────────┼─────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| SALA MEDICA | CORRIDOIO     |SALA OSSIGENO|CORRIDOIO|
        | OVEST   |             | CENTRALE      |             |   EST   |
        |  SUD    |             | SUD           |             |  SUD    |
        |         |             |               |             |         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   :>SEI QUI<|
        | OVEST 1 :   OVEST     |               |    EST      : S.MOT.  |
        |         :   EST       |               |    OVEST    : EST EST |
        |         :             |               |             :         |
        +-────────┼─────────────┼───────╱───────┼─────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapPorto = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-─────────────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        | OVEST   |             |   CENTRALE    |             |   EST   |
        |  NORD   |             |   NORD        |             |  NORD   |
        |         |             |               |             |         |
        +-─────────────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| SALA MEDICA | CORRIDOIO     |SALA OSSIGENO|CORRIDOIO|
        | OVEST   |             | CENTRALE      |             |   EST   |
        |  SUD    |             | SUD           |             |  SUD    |
        |         |             |               |             |         |
        +-─────────────────┼───────────────┼──────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST     |               |    EST      :  EST    |
        |         :   EST       |               |    OVEST    :  EST    |
        |         :             |               |             :         |
        +-─────────────────┼───────────────┼──────────────┤
        ........................|               |
        ........................|>SEI QUI<      |
        ........................|  PORTO        |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(               )
        ........................(    NAVETTA    )
        .........................'─────────────'";

        string mapNavetta = @"
        .............................../^\
        ............................../   \
        ............................./     \
        ....................+-------/       \-------+
        .................../      SALA COMANDI       \
        ................../                           \
        +-─────────────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| RIPOSTIGLIO |   CORRIDOIO   |  ARCHIVIO   |CORRIDOIO|
        | OVEST   |             |   CENTRALE    |             |   EST   |
        |  NORD   |             |   NORD        |             |  NORD   |
        |         |             |               |             |         |
        +-─────────────────┼───────────────┼──────────────┤
        |         |             |               |             |         |
        |CORRIDOIO| SALA MEDICA | CORRIDOIO     |SALA OSSIGENO|CORRIDOIO|
        | OVEST   |             | CENTRALE      |             |   EST   |
        |  SUD    |             | SUD           |             |  SUD    |
        |         |             |               |             |         |
        +-─────────────────┼───────────────┼──────────────┤
        |         :             |               |             :         |
        | S.MOTORI:  S.MOTORI   |   MAGAZZINO   |  S.MOTORI   : S.MOTORI|
        | OVEST 1 :   OVEST     |               |    EST      :  EST    |
        |         :   EST       |               |    OVEST    :  EST    |
        |         :             |               |             :         |
        +-─────────────────┼───────────────┼──────────────┤
        ........................|               |
        ........................|     PORTO     |
        ........................|               |
        ........................+───────╱───────+
        ................................|
        ..........................─────────────.
        ........................(  >SEI QUI<    )
        ........................(    NAVETTA    )
        .........................'─────────────'";


        // ====================================================================
        // 2. CREAZIONE DELLE STANZE CON LA MAPPA CORRISPONDENTE
        // ====================================================================
        Stanza salaComandi = new Stanza("Sala Comandi", "Il ponte di comando della nave. Un'enorme vetrata mostra lo spazio siderale.", mapSComandi);

        Stanza corrOvestN = new Stanza("Corridoio Ovest (Nord)", "La parte nord del corridoio di babordo.", mapONord);
        Stanza ripostiglio = new Stanza("Ripostiglio", "Una piccola stanza piena di attrezzi per la manutenzione.", mapRipostiglio);
        Stanza corrCentraleN = new Stanza("Corridoio Centrale (Nord)", "L'arteria principale della nave.", mapCNord);
        Stanza archivio = new Stanza("Archivio", "Server spenti e faldoni digitali coprono le pareti.", mapArchivio);
        Stanza corrEstN = new Stanza("Corridoio Est (Nord)", "La parte nord del corridoio di tribordo.", mapENord);

        Stanza corrOvestS = new Stanza("Corridoio Ovest (Sud)", "La parte sud del corridoio di babordo.", mapOSud);
        Stanza salaMedica = new Stanza("Sala Medica", "Lettini d'emergenza e macchinari medici.", mapMedica);
        Stanza corrCentraleS = new Stanza("Corridoio Centrale (Sud)", "Il corridoio principale. Da qui si scende verso la stiva.", mapCSud);
        Stanza salaOssigeno = new Stanza("Sala Ossigeno", "Enormi ventole purificano l'aria della nave.", mapOssigeno);
        Stanza corrEstS = new Stanza("Corridoio Est (Sud)", "La parte sud del corridoio di tribordo.", mapESud);

        Stanza motoriOvest1 = new Stanza("Sala Motori Ovest 1", "La parte più esterna del reattore di sinistra.", mapMotoriO1);
        Stanza motoriOvest2 = new Stanza("Sala Motori Ovest 2", "La parte interna del reattore di sinistra, vicino al magazzino.", mapMotoriO2);
        Stanza magazzino = new Stanza("Magazzino", "Casse impilate l'una sull'altra bloccano parzialmente la visuale.", mapMagazzino);
        Stanza motoriEst1 = new Stanza("Sala Motori Est 1", "La parte interna del reattore di destra, vicino al magazzino.", mapMotoriE1);
        Stanza motoriEst2 = new Stanza("Sala Motori Est 2", "La parte più esterna del reattore di destra.", mapMotoriE2);

        Stanza porto = new Stanza("Porto di Sbarco", "La camera di compensazione e attracco navette.", mapPorto);
        Stanza navetta = new Stanza("Navetta", "Il veicolo con cui siete arrivati. I motori sono spenti.", mapNavetta);
        
        // === AGGIUNTA DEI TERMINALI - TEST DI TUTTI E TRE GLI STATI ===
        
        // TERMINALE 1: BLOCCATO (richiede password "1234")
        Terminale terminaleMagazzino = new Terminale("Terminale Logistico", "Un terminale bloccato da password.", StatoTerminale.Bloccato, "1234");
        terminaleMagazzino.logs.Add("MEMO: Smettetela di usare '1234' come password per il magazzino!");
        terminaleMagazzino.logs.Add("AVVISO: Accesso limitato - Verificare credenziali.");
        magazzino.lista.Add(terminaleMagazzino);

        // TERMINALE 2: CRIPTATO (richiede il minigioco Breach Protocol)
        Terminale terminaleOssigeno = new Terminale("Terminale Ambientale", "Il quadro dei comandi vitale. Il sistema è criptato e richiede una violazione.", StatoTerminale.Criptato, "");
        terminaleOssigeno.logs.Add("AVVISO SISTEMA: Rilevato blocco porte.");
        terminaleOssigeno.logs.Add("AUTORITÀ: Protezione crittografica attivata.");
        terminaleOssigeno.logs.Add("NOTA: Tempo limite di vulnerabilità: 30 secondi.");
        salaOssigeno.lista.Add(terminaleOssigeno);

        // TERMINALE 3: SBLOCCATO (accesso immediato)
        Terminale terminaleArchivio = new Terminale("Terminale Archivi", "Un vecchio terminale già sbloccato dal precedente operatore.", StatoTerminale.Sbloccato, "");
        terminaleArchivio.logs.Add("ULTIMO ACCESSO: 72 ore fa");
        terminaleArchivio.logs.Add("STATO: Sistema operativo attivo");
        terminaleArchivio.logs.Add("DATABASE: Dati di navigazione, coordinate stellari, rapporti storici");
        terminaleArchivio.logs.Add("AVVISO: Backup programmato per domani 06:00");
        archivio.lista.Add(terminaleArchivio);

        // ====================================================================
        // 3. CONFIGURAZIONE DELLE PORTE - SECONDO LO SCHEMA SPECIFICATO
        // ====================================================================
        // RIGA 0-1: Sala Comandi <-> Corridoio Centrale Nord
        Porta portaSalaComandi = new Porta("Porta Sala Comandi-Corridoio Centrale Nord", Porta.StatoPorta.Aperta);
        salaComandi.portaSud = portaSalaComandi;
        corrCentraleN.portaNord = portaSalaComandi;

        // RIGA 1: Corridoio Ovest Nord <-> Ripostiglio
        Porta portaCorrOvestNRipostiglio = new Porta("Porta Corridoio Ovest Nord-Ripostiglio", Porta.StatoPorta.Aperta);
        corrOvestN.portaEst = portaCorrOvestNRipostiglio;
        ripostiglio.portaOvest = portaCorrOvestNRipostiglio;

        // RIGA 1: Ripostiglio <-> Corridoio Centrale Nord
        Porta portaRipostCorrCentraleN = new Porta("Porta Ripostiglio-Corridoio Centrale Nord", Porta.StatoPorta.Aperta);
        ripostiglio.portaEst = portaRipostCorrCentraleN;
        corrCentraleN.portaOvest = portaRipostCorrCentraleN;

        // RIGA 1: Corridoio Centrale Nord <-> Archivio
        Porta portaCorrCentraleNArchivio = new Porta("Porta Corridoio Centrale Nord-Archivio", Porta.StatoPorta.Aperta);
        corrCentraleN.portaEst = portaCorrCentraleNArchivio;
        archivio.portaOvest = portaCorrCentraleNArchivio;

        // RIGA 1: Archivio <-> Corridoio Est Nord
        Porta portaArchivioEstN = new Porta("Porta Archivio-Corridoio Est Nord", Porta.StatoPorta.Aperta);
        archivio.portaEst = portaArchivioEstN;
        corrEstN.portaOvest = portaArchivioEstN;

        // RIGA 1-2: Corridoio Ovest Nord <-> Corridoio Ovest Sud
        Porta portaCorrOvestNS = new Porta("Porta Corridoio Ovest Nord-Sud", Porta.StatoPorta.Aperta);
        corrOvestN.portaSud = portaCorrOvestNS;
        corrOvestS.portaNord = portaCorrOvestNS;

        // RIGA 1-2: Corridoio Centrale Nord <-> Corridoio Centrale Sud
        Porta portaCorrCentraleNS = new Porta("Porta Corridoio Centrale Nord-Sud", Porta.StatoPorta.Aperta);
        corrCentraleN.portaSud = portaCorrCentraleNS;
        corrCentraleS.portaNord = portaCorrCentraleNS;

        // RIGA 1-2: Corridoio Est Nord <-> Corridoio Est Sud
        Porta portaCorrEstNS = new Porta("Porta Corridoio Est Nord-Sud", Porta.StatoPorta.Aperta);
        corrEstN.portaSud = portaCorrEstNS;
        corrEstS.portaNord = portaCorrEstNS;

        // RIGA 2: Corridoio Ovest Sud <-> Sala Medica
        Porta portaCorrOvestSSalaMedica = new Porta("Porta Corridoio Ovest Sud-Sala Medica", Porta.StatoPorta.Aperta);
        corrOvestS.portaEst = portaCorrOvestSSalaMedica;
        salaMedica.portaOvest = portaCorrOvestSSalaMedica;

        // RIGA 2: Sala Medica <-> Corridoio Centrale Sud
        Porta portaSalaMedicaCorrCentraleS = new Porta("Porta Sala Medica-Corridoio Centrale Sud", Porta.StatoPorta.Aperta);
        salaMedica.portaEst = portaSalaMedicaCorrCentraleS;
        corrCentraleS.portaOvest = portaSalaMedicaCorrCentraleS;

        // RIGA 2: Corridoio Centrale Sud <-> Sala Ossigeno
        Porta portaCorrCentraleSalaOssigeno = new Porta("Porta Corridoio Centrale Sud-Sala Ossigeno", Porta.StatoPorta.Aperta);
        corrCentraleS.portaEst = portaCorrCentraleSalaOssigeno;
        salaOssigeno.portaOvest = portaCorrCentraleSalaOssigeno;

        // RIGA 2: Sala Ossigeno <-> Corridoio Est Sud
        Porta portaSalaOssigenoCorrEstS = new Porta("Porta Sala Ossigeno-Corridoio Est Sud", Porta.StatoPorta.Aperta);
        salaOssigeno.portaEst = portaSalaOssigenoCorrEstS;
        corrEstS.portaOvest = portaSalaOssigenoCorrEstS;

        // RIGA 2-3: Corridoio Ovest Sud <-> Sala Motori Ovest 1
        Porta portaCorrOvestSMotoriO1 = new Porta("Porta Corridoio Ovest Sud-Sala Motori Ovest 1", Porta.StatoPorta.Aperta);
        corrOvestS.portaSud = portaCorrOvestSMotoriO1;
        motoriOvest1.portaNord = portaCorrOvestSMotoriO1;

        // RIGA 2-3: Corridoio Centrale Sud <-> Magazzino
        Porta portaCorrCentraleSMagazzino = new Porta("Porta Corridoio Centrale Sud-Magazzino", Porta.StatoPorta.Aperta);
        corrCentraleS.portaSud = portaCorrCentraleSMagazzino;
        magazzino.portaNord = portaCorrCentraleSMagazzino;

        // RIGA 2-3: Corridoio Est Sud <-> Sala Motori Est 2
        Porta portaCorrEstSMotoriE2 = new Porta("Porta Corridoio Est Sud-Sala Motori Est 2", Porta.StatoPorta.Aperta);
        corrEstS.portaSud = portaCorrEstSMotoriE2;
        motoriEst2.portaNord = portaCorrEstSMotoriE2;

        // RIGA 3: Sala Motori Ovest 1 <-> Sala Motori Ovest 2
        Porta portaMotoriO1O2 = new Porta("Porta Sala Motori Ovest 1-2", Porta.StatoPorta.Aperta);
        motoriOvest1.portaEst = portaMotoriO1O2;
        motoriOvest2.portaOvest = portaMotoriO1O2;

        // RIGA 3: Sala Motori Ovest 2 <-> Magazzino
        Porta portaMotoriO2Magazzino = new Porta("Porta Sala Motori Ovest 2-Magazzino", Porta.StatoPorta.Aperta);
        motoriOvest2.portaEst = portaMotoriO2Magazzino;
        magazzino.portaOvest = portaMotoriO2Magazzino;

        // RIGA 3: Magazzino <-> Sala Motori Est 1
        Porta portaMagazzinoMotoriE1 = new Porta("Porta Magazzino-Sala Motori Est 1", Porta.StatoPorta.Aperta);
        magazzino.portaEst = portaMagazzinoMotoriE1;
        motoriEst1.portaOvest = portaMagazzinoMotoriE1;

        // RIGA 3: Sala Motori Est 1 <-> Sala Motori Est 2
        Porta portaMotoriE1E2 = new Porta("Porta Sala Motori Est 1-2", Porta.StatoPorta.Aperta);
        motoriEst1.portaEst = portaMotoriE1E2;
        motoriEst2.portaOvest = portaMotoriE1E2;

        // RIGA 3-4: Sala Motori Est 1 <-> Sala Ossigeno
        Porta portaMotoriE1SalaOssigeno = new Porta("Porta Sala Motori Est 1-Sala Ossigeno", Porta.StatoPorta.Aperta);
        motoriEst1.portaNord = portaMotoriE1SalaOssigeno;
        salaOssigeno.portaSud = portaMotoriE1SalaOssigeno;

        // RIGA 4-5: Porto <-> Navetta
        Porta portaPortoNavetta = new Porta("Porta Porto-Navetta", Porta.StatoPorta.Aperta);
        porto.portaSud = portaPortoNavetta;
        navetta.portaNord = portaPortoNavetta;

        // RIGA 3-4: Magazzino <-> Porto
        Porta portaMagazzinoPorto = new Porta("Porta Magazzino-Porto", Porta.StatoPorta.Aperta);
        magazzino.portaSud = portaMagazzinoPorto;
        porto.portaNord = portaMagazzinoPorto;

        // ====================================================================
        // 4. INSERIMENTO NELLA GRIGLIA LOGICA (6 Righe, 5 Colonne)
        // ====================================================================
        map = new Stanza[][] {
            /* Riga 0 */ new Stanza[] { null, null, salaComandi, null, null },
            /* Riga 1 */ new Stanza[] { corrOvestN, ripostiglio, corrCentraleN, archivio, corrEstN },
            /* Riga 2 */ new Stanza[] { corrOvestS, salaMedica, corrCentraleS, salaOssigeno, corrEstS },
            /* Riga 3 */ new Stanza[] { motoriOvest1, motoriOvest2, magazzino, motoriEst1, motoriEst2 },
            /* Riga 4 */ new Stanza[] { null, null, porto, null, null },
            /* Riga 5 */ new Stanza[] { null, null, navetta, null, null }
        };

        // Oggetto iniziale di test
        player.inventario.Push(new Oggetto("Chiave Inglese", "Pesante e arrugginita.", 1.5f, true));

        // Partiamo dalla navetta (Riga 5, Colonna 2)
        player.coordinate = new int[] { 5, 2 };
        player.stanza = navetta;
    }
}

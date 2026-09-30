Console.WriteLine("Hello World!");
Console.WriteLine("Write something creative!");
string userInput = Console.ReadLine();
Console.WriteLine("You wrote: " + userInput);


// ============================================================
// C#-Datentypen im Überblick
// ============================================================

// ------------------------------------------------------------
// 1. EINGEBAUTE (BUILT-IN) TYPEN
// ------------------------------------------------------------

// --- Werttypen ---
// sbyte    -> System.SByte     8 Bit mit Vorzeichen
// byte     -> System.Byte      8 Bit ohne Vorzeichen
// short    -> System.Int16     16 Bit mit Vorzeichen
// ushort   -> System.UInt16    16 Bit ohne Vorzeichen
// int      -> System.Int32     32 Bit mit Vorzeichen
// uint     -> System.UInt32    32 Bit ohne Vorzeichen
// long     -> System.Int64     64 Bit mit Vorzeichen
// ulong    -> System.UInt64    64 Bit ohne Vorzeichen
// nint     -> System.IntPtr    plattformabhängig (32/64 Bit), mit Vorzeichen
// nuint    -> System.UIntPtr   plattformabhängig (32/64 Bit), ohne Vorzeichen
// float    -> System.Single    32-Bit-Gleitkomma
// double   -> System.Double    64-Bit-Gleitkomma
// decimal  -> System.Decimal   128 Bit, exakte Dezimalzahl (z. B. Geld)
// bool     -> System.Boolean   true / false
// char     -> System.Char      ein UTF-16-Zeichen

// --- Referenztypen ---
// string   -> System.String    unveränderlicher Text
// object   -> System.Object    Basistyp von allem
// dynamic  ->                  Typprüfung erst zur Laufzeit

// --- Sonstige Schlüsselwörter ---
// void     kein Rückgabewert
// var      kein Typ, sondern Typinferenz zur Compilezeit

// ------------------------------------------------------------
// 2. SELBST DEFINIERBARE TYPEN
// ------------------------------------------------------------

// --- Werttypen ---
// struct           eigene Werttypen
// readonly struct  unveränderlicher Struct
// ref struct       nur auf dem Stack, z. B. Span<T>
// record struct    Struct mit Wertsemantik und generierten Members
// enum             benannte Konstanten (Basis: int, byte usw.)
// (int, string)    Tupel bzw. ValueTuple<...>
// T? / Nullable<T> nullbare Werttypen, z. B. int?

// --- Referenztypen ---
// class            normale Klassen (auch static, abstract, sealed, partial)
// record           (record class) Klasse mit Wertvergleich, with-Ausdruck
// interface        Verträge (Default-Implementierungen seit C# 8)
// delegate         Methodenzeiger, z. B. Func<>, Action<>, Predicate<>
// int[]            Array (eindimensional)
// int[,]           Array (mehrdimensional)
// int[][]          Array (jagged)
// new { ... }      anonyme Typen, z. B. new { Name = "x", Alter = 3 }
// Tuple<...>       Tupel als Klassenvariante
// Lambda-/Funktionstypen

// --- Zeigertypen (nur in unsafe-Kontext) ---
// int*
// void*
// delegate*<...>   Funktionszeiger

// ------------------------------------------------------------
// 3. WICHTIGE TYPEN AUS DER BASE CLASS LIBRARY (System.*)
// ------------------------------------------------------------

// --- Zahlen ---
// Half             16-Bit-Float
// Int128
// UInt128
// System.Numerics.BigInteger   beliebig große Ganzzahl
// System.Numerics.Complex
// System.Numerics.Vector2 / Vector3 / Vector4
// System.Numerics.Matrix4x4
// System.Numerics.Quaternion
// System.Numerics.Vector<T>

// --- Datum und Zeit ---
// DateTime
// DateTimeOffset
// TimeSpan
// DateOnly
// TimeOnly
// TimeZoneInfo

// --- Identifikation und Sonstiges ---
// Guid
// Uri
// Version
// Type
// Random
// Index            für ^1
// Range            für 1..3
// Enum
// Array
// Delegate
// Exception        (und alle abgeleiteten)
// Lazy<T>
// WeakReference<T>
// Nullable<T>

// --- Text ---
// StringBuilder
// Rune
// Regex
// Encoding
// CultureInfo

// --- Speicher ---
// Span<T>
// ReadOnlySpan<T>
// Memory<T>
// ReadOnlyMemory<T>
// ArraySegment<T>

// ------------------------------------------------------------
// 4. COLLECTIONS
// ------------------------------------------------------------

// --- System.Collections.Generic ---
// List<T>
// LinkedList<T>
// Dictionary<K,V>
// SortedDictionary<K,V>
// SortedList<K,V>
// HashSet<T>
// SortedSet<T>
// Queue<T>
// Stack<T>
// PriorityQueue<TElement,TPriority>
// KeyValuePair<K,V>

// --- System.Collections.Concurrent (threadsicher) ---
// ConcurrentDictionary
// ConcurrentQueue
// ConcurrentStack
// ConcurrentBag
// BlockingCollection

// --- System.Collections.Immutable ---
// ImmutableArray
// ImmutableList
// ImmutableDictionary
// ImmutableHashSet
// usw.

// --- System.Collections.ObjectModel ---
// ObservableCollection<T>
// ReadOnlyCollection<T>
// Collection<T>

// --- Sonstige ---
// BitArray
// BitVector32

// --- Nicht-generisch (veraltet) ---
// ArrayList
// Hashtable
// Queue
// Stack

// --- Wichtige Schnittstellen ---
// IEnumerable<T>
// ICollection<T>
// IList<T>
// IDictionary<K,V>
// IReadOnlyList<T>
// IReadOnlyCollection<T>
// ISet<T>

// ------------------------------------------------------------
// 5. ASYNCHRONITÄT UND THREADING
// ------------------------------------------------------------
// Task
// Task<T>
// ValueTask
// ValueTask<T>
// CancellationToken
// CancellationTokenSource
// Thread
// Mutex
// Semaphore
// SemaphoreSlim
// Lock
// IAsyncEnumerable<T>
// Channel<T>

// ------------------------------------------------------------
// 6. I/O
// ------------------------------------------------------------
// Stream
// FileStream
// MemoryStream
// File
// Directory
// Path
// StreamReader / StreamWriter
// BinaryReader / BinaryWriter

// ------------------------------------------------------------
// KURZREGEL: WERT- VS. REFERENZTYP
// ------------------------------------------------------------
// Werttypen (struct, enum, numerische Typen, bool, char, DateTime, Guid, Tupel)
//   -> werden beim Zuweisen kopiert.
// Referenztypen (class, record, string, Arrays, delegate, interface)
//   -> werden über eine Referenz geteilt.
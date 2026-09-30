Console.WriteLine("Hello World!");
Console.WriteLine("Write something creative!");
string userInput = Console.ReadLine();

// Reversing the input with the method Reverse() and cicle through it with ToArray()
Console.WriteLine(new string(userInput.Reverse().ToArray()));


// ===== [C#] Built-in types =====
// sbyte
// byte
// short
// ushort
// int
// uint
// long
// ulong
// nint
// nuint
// char
// float
// double
// decimal
// bool
// string
// object
// dynamic

// ===== [C#] User-defined types =====
// struct
// readonly struct
// ref struct
// record struct
// enum
// tuple (int, string)
// nullable value type (int?)
// class
// record
// interface
// delegate
// array (int[], int[,], int[][])
// anonymous type
// nullable reference type (string?)
// constructed generic type (Foo<int>)
// type parameter (T)
// pointer (int*, void*, delegate*<...>)

// ===== [C#] Keywords that are not types =====
// void
// var
// lambda

// ===== [.NET] System =====
// Half (s)
// Int128 (s)
// UInt128 (s)
// DateTime (s)
// DateTimeOffset (s)
// TimeSpan (s)
// DateOnly (s)
// TimeOnly (s)
// TimeZoneInfo (c)
// Guid (s)
// Uri (c)
// Version (c)
// Random (c)
// Index (s)
// Range (s)
// Lazy<T> (c)
// WeakReference<T> (c)
// Nullable<T> (s)
// Type (c)
// Enum (c)
// Array (c)
// Delegate (c)
// ValueType (c)
// Exception (c)
// Tuple<...> (c)
// ValueTuple<...> (s)
// Func<...> (d)
// Action<...> (d)
// Predicate<T> (d)
// Span<T> (s)
// ReadOnlySpan<T> (s)
// Memory<T> (s)
// ReadOnlyMemory<T> (s)
// ArraySegment<T> (s)

// ===== [.NET] System.Numerics =====
// BigInteger (s)
// Complex (s)
// Vector2 (s)
// Vector3 (s)
// Vector4 (s)
// Matrix4x4 (s)
// Quaternion (s)
// Vector<T> (s)

// ===== [.NET] System.Text =====
// StringBuilder (c)
// Rune (s)
// Encoding (c)
// Regex (c, in System.Text.RegularExpressions)

// ===== [.NET] System.Globalization =====
// CultureInfo (c)

// ===== [.NET] System.Collections.Generic =====
// List<T> (c)
// LinkedList<T> (c)
// Dictionary<K,V> (c)
// SortedDictionary<K,V> (c)
// SortedList<K,V> (c)
// HashSet<T> (c)
// SortedSet<T> (c)
// Queue<T> (c)
// Stack<T> (c)
// PriorityQueue<TElement,TPriority> (c)
// KeyValuePair<K,V> (s)
// IEnumerable<T> (i)
// ICollection<T> (i)
// IList<T> (i)
// IDictionary<K,V> (i)
// IReadOnlyList<T> (i)
// IReadOnlyCollection<T> (i)
// ISet<T> (i)
// IAsyncEnumerable<T> (i)

// ===== [.NET] System.Collections.Concurrent =====
// ConcurrentDictionary (c)
// ConcurrentQueue (c)
// ConcurrentStack (c)
// ConcurrentBag (c)
// BlockingCollection (c)

// ===== [.NET] System.Collections.Immutable =====
// ImmutableArray (s)
// ImmutableList (c)
// ImmutableDictionary (c)
// ImmutableHashSet (c)

// ===== [.NET] System.Collections.ObjectModel =====
// ObservableCollection<T> (c)
// ReadOnlyCollection<T> (c)
// Collection<T> (c)

// ===== [.NET] System.Collections (non-generic) =====
// ArrayList (c)
// Hashtable (c)
// Queue (c)
// Stack (c)
// BitArray (c)
// BitVector32 (s, in System.Collections.Specialized)

// ===== [.NET] System.Threading =====
// Thread (c)
// Mutex (c)
// Semaphore (c)
// SemaphoreSlim (c)
// Lock (c)
// CancellationToken (s)
// CancellationTokenSource (c)

// ===== [.NET] System.Threading.Tasks =====
// Task (c)
// Task<T> (c)
// ValueTask (s)
// ValueTask<T> (s)

// ===== [.NET] System.Threading.Channels =====
// Channel<T> (c)

// ===== [.NET] System.IO =====
// Stream (c)
// FileStream (c)
// MemoryStream (c)
// File (c)
// Directory (c)
// Path (c)
// StreamReader (c)
// StreamWriter (c)
// BinaryReader (c)
// BinaryWriter (c)


//There are more .NET types but those were the most commonly used ones.

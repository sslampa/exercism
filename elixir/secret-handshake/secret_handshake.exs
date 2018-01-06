defmodule SecretHandshake do
  @doc """
  Determine the actions of a secret handshake based on the binary
  representation of the given `code`.

  If the following bits are set, include the corresponding action in your list
  of commands, in order from lowest to highest.

  1 = wink
  10 = double blink
  100 = close your eyes
  1000 = jump

  10000 = Reverse the order of the operations in the secret handshake
  """
  @spec commands(code :: integer) :: list(String.t())
  def commands(code) do
    bin = Integer.to_string(code, 2) |> String.reverse()
    String.split(bin, "")
    |> Enum.filter(fn (x) -> x != "" end)
    |> Enum.with_index(0)
    |> Enum.map(fn (x) -> 
      b = (elem(x, 0) === "1")
      power = elem(x, 1)
      m = :math.pow(2, power)
      cond do
        m == 1 && b -> "wink"
        m == 2 && b -> "double blink"
        m == 4 && b -> "close your eyes"
        m == 8 && b -> "jump"
        m == 16 && b -> "reverse"
        true -> ""
      end
    end)
    |> (fn(x) ->
      [head | tail] = Enum.reverse(x)
      if head === "reverse" do
        tail
      else
        x
      end
    end).()
    |> Enum.filter(fn(i) -> i != "" end)
  end
end


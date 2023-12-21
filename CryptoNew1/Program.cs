using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using NBitcoin;
using System.Numerics;



namespace ProgrammingBlockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Creating my private key with my key
            byte[] bytes = BigInteger.Parse("11725344435539341571369527625736255434253725643527635436353563846746536545463").ToByteArray();
            Key private_key1 = new Key(bytes); //generates a new private key.
            */


            /* Creating my private key with NBitcoin Framework */
            Key private_key2 = new Key();
            PubKey public_key = private_key2.PubKey; //gets the matching public key.
            Console.WriteLine("Public Key: {0}", public_key);
            KeyId hash = public_key.Hash; //gets a hash of the public key.
            Console.WriteLine("Hashed public key: {0}", hash);
            BitcoinPubKeyAddress address = (BitcoinPubKeyAddress)public_key.GetAddress(ScriptPubKeyType.Legacy, Network.Main);   
            Console.WriteLine("Address: {0}", address);
            Script scriptPubKeyFromAddress = address.ScriptPubKey;
            Console.WriteLine("ScriptPubKey from address: {0}", scriptPubKeyFromAddress);
            Script scriptPubKeyFromHash = hash.ScriptPubKey;
            Console.WriteLine("ScriptPubKey from hash: {0}", scriptPubKeyFromHash);

        }
    }
}

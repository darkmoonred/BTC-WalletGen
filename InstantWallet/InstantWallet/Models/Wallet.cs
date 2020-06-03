using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NBitcoin;
using NBitcoin.RPC;

namespace InstantWallet.Models
{
    public class Wallet
    {

        public string myPublicAddress; // public btc address (For Receiving funds)
        public string myPrivateKey; // private btc address (For Spending Funds)
        public string mnemo; // backup recovery seed phrase


        public void generateKey()
        {

            Key privateKey = new Key(); //generate new key
            PubKey publicKey = privateKey.PubKey; //get public key
            myPublicAddress = publicKey.GetAddress(ScriptPubKeyType.Legacy, Network.Main).ToString(); //convert public key to string

            Key privateKey2 = new Key(); //create private key
            BitcoinSecret mainNetPrivateKey = privateKey2.GetBitcoinSecret(Network.Main); //get the secret key
            myPrivateKey = mainNetPrivateKey.ToString(); // convert private key to string

            mnemo = new Mnemonic(Wordlist.English, WordCount.Twelve).ToString(); //create word list and convert to string

        }
    }
    
}

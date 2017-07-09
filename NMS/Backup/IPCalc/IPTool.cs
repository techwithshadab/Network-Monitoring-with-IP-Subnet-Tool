using System;
using System.Net;

namespace Networks
{
	/// <summary>
	/// Summary description for IPTool.
	/// </summary>
	public class IPTool
	{
		// first (0x00) only for fill - so array starts with bit 1
		static byte [] bit = { 0x00, 0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x40, (byte)0x80 };
		
		protected string ip = null;
		protected byte [] ipBytes = null;
		//protected byte a,b,c,d;
		protected int networkPrefix; // z.b. 24 for /24
		protected bool firstSubNetBit = false;

		public IPTool(string ip)
		{
			this.setIp(ip);
		}

		public static byte getBit(int bit)
		{
			byte r = 0;
			if(bit >= 1 && bit <= 8)
				r = IPTool.bit[bit];

			return r; 
		}
	
		public static byte setBit(byte b, int bit)
		{
			if(bit >= 1 && bit <= 8)
				return (byte) (b | IPTool.bit[bit]);
			else return 0;
		}

		public static bool isBitSet(byte b, int bit)
		{
			bool r = false;
			if(bit >= 1 && bit <= 8)	
				r = ((b & IPTool.bit[bit]) != 0);
				
			return r;
		}


		/*
		 * return true if domainName is an IP
		 */
		static public bool isIP (String domainName)
		{
			//if (domainName.matches("[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}"))
			if (domainName.Equals("[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}"))
				return true;
			else return false;
		}
	
		/*
		 * Converts (unsigned)byte to int
		 */
		public static int byte2int (byte b)
		{
			int i = b;
			if (b < 0) i = b & 0x7f + 128;
		
			return i;
		}
	
		// return first byte of IP
		public byte get1Byte ()
		{
			return this.ipBytes[0];
		}
	
		//	return second byte of IP
		public byte get2Byte ()
		{
			return this.ipBytes[1];
		}

		//	return third byte of IP
		public byte get3Byte ()
		{
			return this.ipBytes[2];
		}
	
		//	return fourth byte of IP
		public byte get4Byte ()
		{
			return this.ipBytes[3];
		}

		//	return array with all bytes of IP
		public byte [] getBytes()
		{
			//return InetAddress.getByName(this.ip).getAddress();
			//return Dns.GetHostByName(this.ip).AddressList;
			return IPAddress.Parse(this.ip).GetAddressBytes();
		}

		public String getIp() 
		{
			return this.ip;
		}

		public void setIp(String ip)
		{
			this.ip = ip;
			this.ipBytes = getBytes();
			this.setPrefix2NetworkClassPrefix();
		}

		public void setPrefix2NetworkClassPrefix ()
		{
			this.setNetworkPrefix(this.getNetworkClassPrefix());
		}

		public int getNetworkClassPrefix ()
		{
			// set network-prefix with Class-Type
			int netClass = getNetworkClass();
			switch (netClass)
			{
				case 0: return 8;	// Class A
				case 1: return 16;	// Class B									
				case 2: return 24;	// Class C
					//default: setNetworkPrefix(-1);	// other Classes have no default Prefix										
			}
			return -1;
		}

		/*
		* return -1 if out of range (0-255) or other error
		*/
		private int convertIPByte(String ipByte)
		{
			//int res = Integer.valueOf(ipByte).intValue();
			int res = Int32.Parse(ipByte);
			if (res < 0 || res > 255) 
			{
				res = -1;
				this.ip = null;
			} 
			return res;
		}

		/**
		 * @return
		 */
		public int getNetworkPrefix() 
		{
			return this.networkPrefix;
		}

		/**
		 * @param prefix
		 */
		public void setNetworkPrefix(int prefix) 
		{
			this.networkPrefix = prefix;
		}

		public String getNetworkClassName ()
		{
			switch (this.getNetworkClass())
			{
				case 0:  return "Class A";
				case 1:  return "Class B";
				case 2:  return "Class C";
				case 3:  return "Class D/Multicast";
				case 4:  return "Class E/not used";		
				default: return "error";
			}
		}
	
		/*
		 * 0=Class A
		 * 1=Class B
		 * 2=Class C
		 * 3=Class D
		 * 4=Class E
		 * -1=error
		 */
		public int getNetworkClass ()
		{
			// Test Class A: first bit=0
			if (!IPTool.isBitSet(this.get1Byte(),8)) return 0;
				// Test Class B: first 2bit=10
			else if (!IPTool.isBitSet(this.get1Byte(),7)) return 1;
				//	Test Class C: first 3bit=110
			else if (!IPTool.isBitSet(this.get1Byte(),6)) return 2;
				//	Test Class D: first 4bit=1110
			else if (!IPTool.isBitSet(this.get1Byte(),5)) return 3;
				//	Test Class E: first 4bit=1111 ( = all other)
				//		else if (!IPTool.isBitSet(this.get1Byte(),8)) return 4;
			else return 4;

		
			/*		
					// Test Class A: first bit=0
					if ((this.get1Byte() | (byte)0x7f) == (byte)0x7f) return 0;
					//	Test Class B: first 2bit=10
					if ((this.get1Byte() | 0xbf) == 0xbf) return 1;
					//	Test Class C: first 3bit=110
					if ((this.get1Byte() | 0xdf) == 0xdf) return 2;
					//	Test Class D: first 4bit=1110
					if ((this.get1Byte() | 0xef) == 0xef) return 3;
					//	Test Class E: first 4bit=1111
					if ((this.get1Byte() & 0xf0) == 0xf0) return 4;		
					return -1;
			*/		
		
		}

		public String getNetworkMask ()
		{
			return getNetworkMaskByPrefix (this.networkPrefix);
		}
	
		public String getNetworkMaskByPrefix (int prefix)
		{
			switch (prefix)
			{
				case  8: return "255.0.0.0";
				case  9: return "255.128.0.0";
				case 10: return "255.192.0.0";
				case 11: return "255.224.0.0";
				case 12: return "255.240.0.0";
				case 13: return "255.248.0.0";
				case 14: return "255.252.0.0";
				case 15: return "255.254.0.0";
				case 16: return "255.255.0.0";
				case 17: return "255.255.128.0";
				case 18: return "255.255.192.0";
				case 19: return "255.255.224.0";
				case 20: return "255.255.240.0";
				case 21: return "255.255.248.0";
				case 22: return "255.255.252.0";
				case 23: return "255.255.254.0";
				case 24: return "255.255.255.0";
				case 25: return "255.255.255.128";
				case 26: return "255.255.255.192";
				case 27: return "255.255.255.224";
				case 28: return "255.255.255.240";
				case 29: return "255.255.255.248";
				case 30: return "255.255.255.252";
				default: return "";
			}
		}
	
		public int getMaxNetworkHosts ()
		{
			// 2^(32-networkprefix)
			// -2 ... because .0 and .255
			return ((int)Math.Pow(2,(32-this.networkPrefix)))-2;
		}
	
		public int getMaxSubNets ()
		{
			// Bits from Subnet = prefix-class_prefix
		
			int count = (int)Math.Pow(2, this.networkPrefix - this.getNetworkClassPrefix());
		
			//	-2 because 1 bit for routing
			if (!this.isFirstSubNetBit() || this.getNetworkClassPrefix()==this.networkPrefix)
				count-=2;
		
			if (count < 0 ) count = 0;
			return count;
		}
	
		public long getNetworkLong ()
		{
			long mask = (long)Math.Pow (2, this.networkPrefix)-1;
			mask = mask << (32-this.networkPrefix);
		
			return (mask & ip2Long());
		}

		public String getNetwork ()
		{
			return long2String(getNetworkLong());
		}

		public long getBroadCastLong ()
		{
			long netMask = (long)Math.Pow (2, this.networkPrefix)-1;
			netMask = netMask << (32-this.networkPrefix);
			long hostMask = (long) Math.Pow(2, 32-this.networkPrefix)-1;

			return (netMask = (ip2Long() & netMask) | hostMask);	
		}

		public String getBroadCast ()
		{
			return long2String(getBroadCastLong());	
		}

	
		public String[] getNetworkIPRange ()
		{
			String [] result = new String [2];
			//String from, to;
			/**
			 * Start
			 * +1 because first = network
			 */
			result [0] = long2String (getNetworkLong() + 1);	
			/**
			 * End
			 * -1 because last = broadcast
			 */
			result [1] = long2String(getBroadCastLong() -1);
			return result;
		}
	
		public long ip2Long ()
		{
			return ((long)(IPTool.byte2int(this.get1Byte()) * 256 + 
				IPTool.byte2int(this.get2Byte())) * 256 + 
				IPTool.byte2int(this.get3Byte())) * 256 + 
				IPTool.byte2int(this.get4Byte());
		}
	
		public String long2String (long ip)
		{
			long a = (long)(ip & 0xff000000) >> 24;
			long b = (long)(ip & 0x00ff0000) >> 16;
			long c = (long)(ip & 0x0000ff00) >> 8;
			long d = (long)(ip & 0xff);

			return a+"."+b+"."+c+"."+d;
		}	
		
		public bool isFirstSubNetBit() 
		{
			return firstSubNetBit;
		}

		public void setFirstSubNetBit(bool b) 
		{
			firstSubNetBit = b;
		}

		public static IPTool getNextIP (String ip)
		{
			IPTool nextIp = new IPTool (ip);
			nextIp.setIp(nextIp.long2String(nextIp.ip2Long()+(long)1));

			return nextIp;

		}

		public IPTool getNextSubNet (long numberOfHosts)
		{
			IPTool ip = IPTool.getNextIP(this.getBroadCast());
			ip.setIp(this.long2String(ip.ip2Long()+(long)1));
			ip.setFirstSubNetBit(this.isFirstSubNetBit());
		
			int lastPrefix = ip.getNetworkClassPrefix();
		
			int prefix = 30;
			do 
			{
				if (prefix < ip.getNetworkClassPrefix()) 
					return null; // no subnet found
				ip.setNetworkPrefix(prefix);
				prefix--;
				// ignore subnetbit?
				if (!ip.isFirstSubNetBit() && prefix == lastPrefix+1) prefix--;
			
			}
			while (ip.getMaxNetworkHosts() < numberOfHosts);

			return ip;
		}
	}
}
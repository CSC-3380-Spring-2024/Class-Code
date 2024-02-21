namespace Set{
	public class Set<Element> where Element : IComparable{
		public List<Element> set;


		public Set(){
			set = new List<Element>();
		}

		public Set(List<Element> set){
			this.set = set;
			this.RemoveDuplicates();
		}

		//
		public void RemoveDuplicates(){
			for(int i = 1; i < set.Count; i++){
				if(set[i].Equals(set[i-1])){
					set.Remove(set[i]);
				}
			}
		}

		public int Count{
			get {return set.Count;}
		}


		public bool Contains(Element elem){
			return set.Contains(elem);
		}

		public bool Contains(Set<Element> set){
			bool isContained = true;

			if(this.Count < set.Count)
				return false;

			foreach(Element elem in set.set){
				if(!this.set.Contains(elem)){
					isContained = false;
					break;
				}
			}

			return isContained;
		}

		public void Sort(){
			set.Sort();
		}

		public void Add(Element elem){
			if(set.Contains(elem))
				return;
			set.Add(elem);
			set.Sort();
		}

		public void Add(Set<Element> set){
			foreach(Element elem in set.set){
				this.set.Add(elem);
			}
			this.set.Sort();
			RemoveDuplicates();
		}

		public static Set<Element> operator +(Set<Element> set, Element elem){
			set.Add(elem);

			return set;
		}

		public bool Remove(Element elem){
			return set.Remove(elem);
		}

		public static Set<Element> operator -(Set<Element> set1, Set<Element> set2){
			foreach(Element e in set2.set){
				set1.Remove(e);
			}

			return set1;
		}

		public static Set<Element> operator &(Set<Element> set1, Set<Element> set2){
			Set<Element> returnSet = new Set<Element>();
			foreach(Element elem in set2.set){
				if(set1.Contains(elem)){
					returnSet.Add(elem);
				}
			}
			return returnSet;
		}

		public static Set<Element> operator |(Set<Element> set1, Set<Element> set2){
			Set<Element> returnSet = set1;
			returnSet.Add(set2);
			return returnSet;
		}

		public bool Equals(Set<Element> compSet){
			int set_size = set.Count;

			if(set_size != compSet.Count){
				return false;
			}

			for(int i = 0; i < set_size; i++){
				if(!set[i].Equals(compSet[i])){
					return false;
				}
			}

			return true;
		}

		public static bool operator ==(Set<Element> set1, Set<Element> set2){
			return set1.Equals(set2);
		}

		public static bool operator !=(Set<Element> set1, Set<Element> set2){
			return !set1.Equals(set2);
		}

		public Element this[int i]{
			get { return set[i]; }
			set { set[i] = value; }
		}

		public static bool operator true(Set<Element> set){
			return set.Count > 0;
		}

		public static bool operator false(Set<Element> set){
			return set.Count == 0;
		}

		public bool Subset(Set<Element> compSet){
				return Contains(compSet);
		}

		public static bool operator >(Set<Element> set1, Set<Element> set2){
			return set1.Subset(set2);
		}

		public static bool operator <(Set<Element> set1, Set<Element> set2){
			return set2.Subset(set1);
		}

	}
}
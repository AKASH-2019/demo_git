/** 
 *    created by akash 14-06-2022
 * */
 
# include <bits/stdc++.h>
using namespace std;

/*struct Node{
	char data;
	Node *left, *right;
	
	Node(char data){
		this->data = data;
		this->left = this->right = nullptr;
	};
	Node(char data, Node *left, Node *right){
		this->data = data;
		this->left = left;
		this->right = right;
	};
};*/
struct Node
{
    char data;
    Node *left, *right;
 
    /*Node(char data)
    {
        this->data = data;
        this->left = this->right = nullptr;
    };
 
    Node(char data, Node *left, Node *right)
    {
        this->data = data;
        this->left = left;
        this->right = right;
    };*/
};

bool isOperator(char c){
	return (c=='+' || c=='-' || c=='*' || c=='/' || c=='^');
}

void postorder(Node* root){
	if (root == nullptr) {
        return;
    }
 
    postorder(root->left);
    postorder(root->right);
    cout << root->data;
}

void inorder(Node* root){
	if(root == nullptr){
		return;
	}
	
	if (isOperator(root->data)) {
        cout << "(";
    }
	
	inorder(root->left);
	cout<<root->data;
	inorder(root->right);
	
	if (isOperator(root->data)) {
        cout << ")";
    }
}


Node* construct(string postfix){
	// cout<<postfix.length()<<endl;
	if(postfix.length() == 0){
		return nullptr;
	}
	
	
	stack<Node*>s;
	
	for(char c:postfix){
		// cout<<"character "<<c<<endl;
		if(isOperator(c)){
			 Node* x = s.top();
			 s.pop();
			 Node* y = s.top();
			 s.pop();
			 
			 // construct a new binary tree whose root is the operator and whose
             // left and right children point to `y` and `x`, respectively
			 //Node* node = new Node(c, x, y);
			 Node* node = new Node();
			 node->data = c;
             node->left = x;
             node->right = y;
			 // push the current node into the stack
			 s.push(node);
		}
		// if the current token is an operand, create a new binary tree node
        // whose root is the operand and push it into the stack
		else{
			Node* node = new Node();
			node->data = c;
            node->left = node->right = nullptr;
            
			//s.push(new Node(c));
			s.push(node);
		}
	}
	
	return s.top();
}


int main()
{
	string postfix = "ab+cde+**";
	Node* root = construct(postfix);
	
	// postorder
	postorder(root); 
	
	cout<<endl;
	
	// inorder
	inorder(root); 
	
	return 0;
}


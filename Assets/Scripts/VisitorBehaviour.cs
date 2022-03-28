using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace VisitorPattern {
    public class VisitorBehaviour : MonoBehaviour {
    
        void Start()
        {
            HumanVisitor h = new HumanVisitor();
            MonsterVisitor m = new MonsterVisitor();
            BodyHitBox b = new BodyHitBox(1.0);
            HeadHitBox he = new HeadHitBox(5.0);
            EnvironmentHitBox e = new EnvironmentHitBox(3.0);
            h.visit(b);
            h.visit(he);
            h.visit(e);

            m.visit(b);
            m.visit(he);
            m.visit(e);

        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
    //interface of visitor
    public interface Visitor {
        void visit(BodyHitBox hit);
        void visit(HeadHitBox hit);
        void visit(EnvironmentHitBox hit);
    }

    //implementation of ak hit
    public class MonsterVisitor : Visitor {
        public double _health = 1000.0;
        public void visit(BodyHitBox hit) {
            Debug.Log("monster body hit, remaining hp - " + (_health-hit.damage * 30));
            _health -= hit.damage * 30;
        }
        public void visit(HeadHitBox hit) {
            Debug.Log("monster head hit, remaining hp - " + (_health-hit.damage * 80));
            _health -= hit.damage * 80;
        }
        public void visit(EnvironmentHitBox hit) {
            Debug.Log("monster miss hit, remaining hp - " + (_health));
        }
    }

    //implementation of pistol hit
    public class HumanVisitor : Visitor {
        public double _health = 150.0;
        public void visit(BodyHitBox hit) {
            Debug.Log("human body hit, remaining hp - " + (_health-hit.damage * 13));
            _health -= hit.damage * 13;
        }
        public void visit(HeadHitBox hit) {
            Debug.Log("human head hit, remaining hp - " + (_health-hit.damage * 40));
            _health -= hit.damage * 40;
        }
        public void visit(EnvironmentHitBox hit) {
            Debug.Log("human miss hit, remaining hp - " + (_health));
        }
    }

    public class Hit {
        public double damage;
        public Hit(double damage1) {
            this.damage = damage1;
        }
        public double getDamage() {
            return this.damage;
        }
        public void setDamage(double damage1) {
            this.damage = damage1;
        }
    }

    public class BodyHitBox : Hit {
        public BodyHitBox(double damage1):base (damage1) {
            this.damage = damage1;
        }
        public double getDamage() {
            return this.damage;
        }
        public void setDamage(double damage1) {
            this.damage = damage1;
        }
    }

    public class HeadHitBox : Hit {
        public HeadHitBox(double damage1):base (damage1) {
            this.damage = damage1;
        }
        public double getDamage() {
            return this.damage;
        }
        public void setDamage(double damage1) {
            this.damage = damage1;
        }
    }

    public class EnvironmentHitBox : Hit {
        public EnvironmentHitBox(double damage1):base (damage1) {
            this.damage = damage1;
        }
        public double getDamage() {
            return this.damage;
        }
        public void setDamage(double damage1) {
            this.damage = damage1;
        }
    }

}

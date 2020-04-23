using System;
using System.Collections.Generic;
using System.Text;

namespace BasicJira
{
    public enum TicketType { Task, Bug }

    public enum TicketStatus
    {
        ToDo,
        InProgress,
        ReadyForTesting,
        BeingTested,
        Done
    }

    class Ticket
    {
        private Guid id;
        private string title;
        private TicketType type;
        private Member assignee;
        private DateTime creationDate;
        private DateTime completionDate;
        private double estimatedTime;
        private double completionTime;
        private TicketStatus status;
        private string description;
        private List<Comment> comments;
        private Member author;

        //Properties 
        public Guid ID { get; }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value.Length < 255)
                {
                    title = value;
                }
                else
                {
                    throw new InvalidOperationException("Value cannot be greater than 255");
                }
            }
        }

        public TicketType Type { get; }

        public Member Assignee { get; set; }

        public DateTime CreationDate { get; }

        public DateTime CompletionDate { get; }

        public double EstimatedTime { get; set; }

        public double CompletionTime
        {
            get
            {
                return (completionDate - creationDate).TotalHours;
            }
        }

        public TicketStatus Status { get; set; }

        public string Description { get; set; }

        public List<Comment> Comments { get; }

        public Member Author { get; }

        public Ticket(string title, Member author, string description, double estimatedTime)
        {
            this.id = Guid.NewGuid();
            this.title = title;
            this.type = (author.Role == MemberRole.QA) ? TicketType.Bug : TicketType.Task;
            this.creationDate = DateTime.Now;
            this.description = description;
            this.status = TicketStatus.ToDo;
            this.comments = new List<Comment>();
            this.estimatedTime = estimatedTime;
        }

        //Methods
        public void AddComment(Comment comment)
        {
            this.comments.Add(comment);
        }

        public void ChangeStatusToToDo()
        {

            if (this.status == TicketStatus.InProgress || this.status == TicketStatus.ReadyForTesting)
            {
                this.status = TicketStatus.ToDo;
            }
            else
            {
                throw new InvalidOperationException("Cannot perform this operation.");
            }
        }

        public void ChangeStatusToInProgress()
        {
            if (this.assignee.Role == MemberRole.Programmer && this.status == TicketStatus.ToDo)
            {
                this.status = TicketStatus.InProgress;
            }
            else
            {
                throw new InvalidOperationException("You must have assignee of type programmer");
            }
        }
        public void ChangeStatusToReadyForTesting()
        {
            this.assignee = null;
            this.status = TicketStatus.ReadyForTesting;
        }

        public void ChangeStatusToBeingTested()
        {
            if (this.assignee.Role == MemberRole.QA && this.status == TicketStatus.ReadyForTesting)
            {
                this.status = TicketStatus.BeingTested;
            }
            else
            {
                throw new InvalidOperationException("You must have assignee of type QA");
            }
        }

        public void ChangeStatusToDone()
        {

            if (this.status == TicketStatus.BeingTested && this.assignee != null && this.assignee.Role == MemberRole.QA)

            {
                this.status = TicketStatus.Done;
            }
            else
            {
                throw new InvalidOperationException("You cannot move it to done if you're not a QA!!!!!!!!");
            }
        }
        public void LogTimeToTicket(double hours)
        {
            if (this.assignee != null)
            {

                this.completionTime += hours;
            }

        }

    }
}












    }
}
